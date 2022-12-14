using System;
using back_salidaActivos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace back_salidaActivos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class SolicitudAreaController : ApiController
    {
        // GET: api/SolicitudArea
        public IEnumerable<areas> Get()
        {
            GestorAreas gAreas = new GestorAreas();
            return gAreas.GetAreas();

        }
       
        // GET: api/Solicitud/5
        public IEnumerable<solicitud> Get(int id)
        {

            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudsById(id);


        }



        // POST: api/Solicitud2
     //   public bool Post([FromBody] solicitudPreventiva SolicitudPreventiva)
       // {
         //   GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
           // bool res = gSolicitud.addSolicitud2(SolicitudPreventiva);

            //return res;
        //}
        // POST: api/SolicitudArea
        public bool Post([FromBody] areas Areas)
        {
            GestorAreas gAreas = new GestorAreas();
            bool res = gAreas.addAreas(Areas);

            return res;
        }



        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody]solicitud Solicitud)
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            bool res = gSolicitud.updateSolicitud(id,Solicitud);

            return res;
        }

        // DELETE: api/Solicitud/5
        public bool Delete(int id)
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            bool res = gSolicitud.deleteSolicitud(id);

            return res;
        }
    }
}
