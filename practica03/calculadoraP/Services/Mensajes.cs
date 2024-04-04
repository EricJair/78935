using System;
using System.ServiceModel;

namespace WSDL.mensajes {
	[ServiceContract]
	public interface Mensajes{
	[OperationContract]
	int Suma (int numero);
	[OperationContract]
	int Resta (int numero);
	}
}
