using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Newtonsoft.Json;

namespace WebAerolinea.Controllers
{
    public class PasajeroController : Controller
    {
        // GET: Pasajero
        public ActionResult Index()
        {
            DataTable dt = new DataTable();

            Pasajero p = new Pasajero { Apellidos = "", Tipo_Ident = "", Email = "",Nombre="",Numero_Ident="",Telefono="" };
            List<Pasajero> listaPasajero = new List<Pasajero>();
            WS_Aerolinea.ServiceClient _ws = new WebAerolinea.WS_Aerolinea.ServiceClient();

            dt = (JsonConvert.DeserializeObject<DataTable>(_ws.WS_Pasajero(5,JsonConvert.SerializeObject(p,Formatting.Indented))));
            foreach (DataRow i in dt.Rows) 
            {
                p = new Pasajero
                {
                    Id_Pasajero = int.Parse(i["Id_Pasajero"].ToString()),
                    Tipo_Ident = i["Tipo_Ident"].ToString(),
                    Numero_Ident = i["Numero_Ident"].ToString(),
                    Nombre = i["Nombre"].ToString(),
                    Apellidos = i["Apellidos"].ToString(),
                    Telefono = i["Telefono"].ToString(),
                    Email = i["Email"].ToString()
                };
                listaPasajero.Add(p);
            }
            ViewData["Pasajeros"] = listaPasajero;
          
            return View();
        }

        // GET: Pasajero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pasajero/Create
        public ActionResult Create()
        {
            List<string> TipoDocumento = new List<string>();
            TipoDocumento.Add("C.Ciudadania");
            TipoDocumento.Add("CExtranjeria");
            TipoDocumento.Add("NIT");
            TipoDocumento.Add("Pasaporte");
            ViewBag.SelecionDocumento = new SelectList(TipoDocumento);
            return View();
        }

        // POST: Pasajero/Create
        [HttpPost]
        public ActionResult Create(Pasajero collection)
        {
            try
            {
                WS_Aerolinea.ServiceClient _ws = new WebAerolinea.WS_Aerolinea.ServiceClient();
                int valide = 0;
                 valide= (JsonConvert.DeserializeObject<int>(_ws.WS_Pasajero(1, JsonConvert.SerializeObject(collection, Formatting.Indented))));
                if (valide > 0)
                {
                    return RedirectToAction("Index");
                }
                else 
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Pasajero/Edit/5
        public ActionResult Edit(string id,string type)
        {
            DataTable dt = new DataTable();
            Pasajero p = new Pasajero { Apellidos = "", Tipo_Ident = type, Email = "", Nombre = "", Numero_Ident = id, Telefono = "" };
            List<string> TipoDocumento = new List<string>();
            TipoDocumento.Add("C.Ciudadania");
            TipoDocumento.Add("CExtranjeria");
            TipoDocumento.Add("NIT");
            TipoDocumento.Add("Pasaporte");
            ViewBag.SelecionDocumento = new SelectList(TipoDocumento);
            WS_Aerolinea.ServiceClient _ws = new WebAerolinea.WS_Aerolinea.ServiceClient();
            dt = (JsonConvert.DeserializeObject<DataTable>(_ws.WS_Pasajero(4, JsonConvert.SerializeObject(p, Formatting.Indented))));
            foreach (DataRow i in dt.Rows)
            {
                p = new Pasajero
                {
                    Id_Pasajero = int.Parse(i["Id_Pasajero"].ToString()),
                    Tipo_Ident = i["Tipo_Ident"].ToString(),
                    Numero_Ident = i["Numero_Ident"].ToString(),
                    Nombre = i["Nombre"].ToString(),
                    Apellidos = i["Apellidos"].ToString(),
                    Telefono = i["Telefono"].ToString(),
                    Email = i["Email"].ToString()
                };
                ;
            }
            return View(p);
        }

        // POST: Pasajero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pasajero collection)
        {
            try
            {
                WS_Aerolinea.ServiceClient _ws = new WebAerolinea.WS_Aerolinea.ServiceClient();
                int valide = 0;
                valide = (JsonConvert.DeserializeObject<int>(_ws.WS_Pasajero(2, JsonConvert.SerializeObject(collection, Formatting.Indented))));
                if (valide > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Pasajero/Delete/5
        public ActionResult Delete(string Num_Ident,int id, string type)
        {
            DataTable dt = new DataTable();
            Pasajero p = new Pasajero { Apellidos = "", Tipo_Ident = type, Email = "", Nombre = "", Numero_Ident = Num_Ident, Telefono = "" };
            List<string> TipoDocumento = new List<string>();
            TipoDocumento.Add("C.Ciudadania");
            TipoDocumento.Add("CExtranjeria");
            TipoDocumento.Add("NIT");
            TipoDocumento.Add("Pasaporte");
            ViewBag.SelecionDocumento = new SelectList(TipoDocumento);
            WS_Aerolinea.ServiceClient _ws = new WebAerolinea.WS_Aerolinea.ServiceClient();
            dt = (JsonConvert.DeserializeObject<DataTable>(_ws.WS_Pasajero(4, JsonConvert.SerializeObject(p, Formatting.Indented))));
            foreach (DataRow i in dt.Rows)
            {
                p = new Pasajero
                {
                    Id_Pasajero = int.Parse(i["Id_Pasajero"].ToString()),
                    Tipo_Ident = i["Tipo_Ident"].ToString(),
                    Numero_Ident = i["Numero_Ident"].ToString(),
                    Nombre = i["Nombre"].ToString(),
                    Apellidos = i["Apellidos"].ToString(),
                    Telefono = i["Telefono"].ToString(),
                    Email = i["Email"].ToString()
                };
                ;
            }
            return View(p);
        }

        // POST: Pasajero/Delete/5
        [HttpPost]
        public ActionResult Delete(string Num_Ident, int id, string type, Pasajero collection)
        {
            try
            {
                collection= new Pasajero{Id_Pasajero = id ,Apellidos = "", Tipo_Ident = "", Email = "", Nombre = "", Numero_Ident = "", Telefono = "" };
                WS_Aerolinea.ServiceClient _ws = new WebAerolinea.WS_Aerolinea.ServiceClient();
                int valide = 0;
                valide = (JsonConvert.DeserializeObject<int>(_ws.WS_Pasajero(3, JsonConvert.SerializeObject(collection, Formatting.Indented))));
                if (valide > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
