using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using Newtonsoft.Json;


	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
	public class Service : IService
	{
		public DataInfo Informacion;


		
		public string WS_Pasajero(int type, string _pasajero)
		{
			Informacion = new DataInfo();
			Pasajero pasajero = new Pasajero();
			pasajero = JsonConvert.DeserializeObject<Pasajero>(_pasajero);
			return Informacion.SP_Pasajero(type, pasajero);


		}
		
		public string WS_Viaje(int type, string _viaje)
		{
			Informacion = new DataInfo();
			Viaje viaje = new Viaje();
			viaje = JsonConvert.DeserializeObject<Viaje>(_viaje);
			return Informacion.SP_Viaje(type, viaje);

		}
		
		public string WS_ServicioAdicional(int type, string _servicio)
		{
			Informacion = new DataInfo();
			Servicio_Adicional servicio = new Servicio_Adicional();
			servicio = JsonConvert.DeserializeObject<Servicio_Adicional>(_servicio);
		return JsonConvert.SerializeObject(Informacion.SP_Servicio_Adicional(type, servicio), Formatting.Indented);


		}
		
		public string WS_Maleta(int type, string _maleta)
		{
			Informacion = new DataInfo();
			Maleta maleta = new Maleta();
			maleta = (Maleta)JsonConvert.DeserializeObject<Maleta>(_maleta);
		return JsonConvert.SerializeObject(Informacion.SP_Maleta(type, maleta), Formatting.Indented);
		}

	}

