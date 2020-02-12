using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuessingGameFrontEnd.Models;
using System.Net;
using System.IO;

namespace GuessingGameFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string baseURL = "http://localhost:59147/Service.svc";

        private static SecretNumberModel ControllerSecretNumberModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ViewResult GenSecretNumberForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult GenSecretNumberForm(SecretNumberModel secretNumber)
        {
            GenerateSecretNumber(secretNumber);
            return View("Index", secretNumber);
        }

        [HttpGet]
        public ViewResult GuessSecretNumberForm()
        {
            return View("GuessSecretNumberForm", ControllerSecretNumberModel);
        }

        [HttpPost]
        public ViewResult GuessSecretNumberForm(SecretNumberModel secretNumber)
        {
            GuessSecretNumber(secretNumber);
            return View("Index", ControllerSecretNumberModel);
        }

        [HttpGet]
        public ViewResult CheckRequest()
        {
            return View("Index", ControllerSecretNumberModel);
        }

        public void GenerateSecretNumber(SecretNumberModel secretNumber)
        {
            // Create the url
            string secretNumberUrl = baseURL + $"/SecretNumber?lower={secretNumber.LowerBound}&upper={secretNumber.UpperBound}";
            // Create a request object
            HttpWebRequest secretRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(secretNumberUrl));
            // Get a response async
            secretRequest.BeginGetResponse(new AsyncCallback(GenerateSecretNumberCallback), secretRequest);
            secretNumber.CodeResponse = "Generate Secret Number Request Sent";
            ControllerSecretNumberModel = secretNumber;
        }

        private void GenerateSecretNumberCallback(IAsyncResult requestObject)
        {
            HttpWebRequest requestAsyncState = (HttpWebRequest)requestObject.AsyncState;
            HttpWebResponse secretResponse = (HttpWebResponse)requestAsyncState.EndGetResponse(requestObject);
            using (StreamReader reader = new StreamReader(secretResponse.GetResponseStream()))
            {
                string responseStr = reader.ReadToEnd();
                var xml = System.Xml.Linq.XElement.Parse(responseStr);
                ControllerSecretNumberModel.SecretNumber = int.Parse(xml.FirstNode.ToString());
                ControllerSecretNumberModel.CodeResponse = "Secret Number Generated";
            }
        }

        public void GuessSecretNumber(SecretNumberModel secretNumber)
        {
            ControllerSecretNumberModel.UserGuess = secretNumber.UserGuess;
            // Create the url
            string checkNumberUrl = baseURL + $"/CheckNumber?userNumber={ControllerSecretNumberModel.UserGuess}&secretNumber={ControllerSecretNumberModel.SecretNumber}";
            // Create a request object
            HttpWebRequest checkRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(checkNumberUrl));
            // Get a response async
            checkRequest.BeginGetResponse(new AsyncCallback(GuessSecretNumberCallback), checkRequest);
            ControllerSecretNumberModel.CodeResponse = "Check Number Request Sent.";
        }

        private void GuessSecretNumberCallback(IAsyncResult requestObject)
        {
            HttpWebRequest requestAsyncState = (HttpWebRequest)requestObject.AsyncState;
            HttpWebResponse secretResponse = (HttpWebResponse)requestAsyncState.EndGetResponse(requestObject);
            using (StreamReader reader = new StreamReader(secretResponse.GetResponseStream()))
            {
                string responseStr = reader.ReadToEnd();
                var xml = System.Xml.Linq.XElement.Parse(responseStr);
                ControllerSecretNumberModel.CodeResponse = xml.FirstNode.ToString();
            }
        }
    }
}
