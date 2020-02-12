using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
	[WebGet(UriTemplate = "SecretNumber?lower={lower}&upper={upper}", ResponseFormat = WebMessageFormat.Xml)]
	int SecretNumber(int lower, int upper);

	[OperationContract]
	[WebGet(UriTemplate = "CheckNumber?userNumber={userNumber}&secretNumber={secretNumber}", ResponseFormat = WebMessageFormat.Xml)]
	string CheckNumber(int userNumber, int secretNumber);
}
