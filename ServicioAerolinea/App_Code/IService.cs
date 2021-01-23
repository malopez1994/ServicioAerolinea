using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;


	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
	[ServiceContract]
	public interface IService
	{

		[OperationContract]
		 string WS_Pasajero(int type, string _pasajero);
		[OperationContract]
	string WS_Viaje(int type, string _viaje);
		[OperationContract]
	string WS_ServicioAdicional(int type, string _servicio);
		[OperationContract]
	string WS_Maleta(int type, string _maleta);


		// TODO: agregue aquí sus operaciones de servicio
	}

	// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

