using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProyectoFinal.Vista.Controllers
{
    public class JuegosController : Controller
    {
        private Traductor _traductor = new Traductor();
        private List<juegos> _juegos = new List<juegos>();
        private List<generos> _generos = new List<generos>();
        private List<distribudores> _distribuidores = new List<distribudores>();
        private List<desarrolladores> _desarrolladores = new List<desarrolladores>();

        public ActionResult Genero(int id,string titulo)
        {
            dynamic ArrayJuegos = _traductor.Get("https://localhost:44335/api/juegos/BuscarPorGenero/" + id.ToString());
            foreach (var item in ArrayJuegos)
            {
                juegos juego = new juegos();
                juego.juego_id = item.juego_id;
                juego.titulo = item.titulo;
                juego.fecha_lanzamiento = item.fecha_lanzamiento;
                juego.imagen = item.imagen;
                juego.distribuidor_id = item.distribuidor_id;
                _juegos.Add(juego);
            }

            ViewData["juegos"] = _juegos;
            ViewData["titulo"] = titulo;

            return View();
        }

        public ActionResult Desarrollador(int id, string titulo)
        {
            dynamic ArrayJuegos = _traductor.Get("https://localhost:44335/api/juegos/BuscarPorDesarrollador/" + id.ToString());
            foreach (var item in ArrayJuegos)
            {
                juegos juego = new juegos();
                juego.juego_id = item.juego_id;
                juego.titulo = item.titulo;
                juego.fecha_lanzamiento = item.fecha_lanzamiento;
                juego.imagen = item.imagen;
                juego.distribuidor_id = item.distribuidor_id;
                _juegos.Add(juego);
            }

            ViewData["juegos"] = _juegos;
            ViewData["titulo"] = titulo;

            return View();
        }

        public ActionResult Distribuidor(int id, string titulo)
        {
            dynamic ArrayJuegos = _traductor.Get("https://localhost:44335/api/juegos/BuscarPorDistribuidor/" + id.ToString());
            foreach (var item in ArrayJuegos)
            {
                juegos juego = new juegos();
                juego.juego_id = item.juego_id;
                juego.titulo = item.titulo;
                juego.fecha_lanzamiento = item.fecha_lanzamiento;
                juego.imagen = item.imagen;
                juego.distribuidor_id = item.distribuidor_id;
                _juegos.Add(juego);
            }

            ViewData["juegos"] = _juegos;
            ViewData["titulo"] = titulo;

            return View();
        }

        // GET: Juegos
        public ActionResult Index()
        {

            dynamic ArrayJuegos = _traductor.Get("https://localhost:44335/api/juegos");
            foreach (var item in ArrayJuegos)
            {
                juegos juego = new juegos();
                juego.juego_id = item.juego_id;
                juego.titulo = item.titulo;
                juego.fecha_lanzamiento = item.fecha_lanzamiento;
                juego.imagen = item.imagen;
                juego.distribuidor_id = item.distribuidor_id;
                _juegos.Add(juego);
            }

            dynamic Arraygeneros = _traductor.Get("https://localhost:44335/api/generos");
            foreach (var item in Arraygeneros)
            {
                generos genero = new generos();
                genero.genero_id = item.genero_id;
                genero.genero_descripcion = item.genero_descripcion;
                _generos.Add(genero);
            }

            dynamic ArrayDistribuidores = _traductor.Get("https://localhost:44335/api/distribudores");
            foreach (var item in ArrayDistribuidores)
            {
                distribudores distribuidor = new distribudores();
                distribuidor.distribuidor_id = item.distribuidor_id;
                distribuidor.distribuidor_razonsocial = item.distribuidor_razonsocial;
                distribuidor.distribuidor_fecha_fundacion = item.distribuidor_fecha_fundacion;
                _distribuidores.Add(distribuidor);
            }

            dynamic ArrayDesarrolladores = _traductor.Get("https://localhost:44335/api/desarrolladores");
            foreach (var item in ArrayDesarrolladores)
            {
                desarrolladores desarrollador = new desarrolladores();
                desarrollador.desarrollador_id = item.desarrollador_id;
                desarrollador.desarrollador_razonsocial = item.desarrollador_razonsocial;
                desarrollador.desarrollador_fecha_fundacion = item.desarrollador_fecha_fundacion;
                _desarrolladores.Add(desarrollador);
            }

            ViewData["juegos"] = _juegos;
            ViewData["generos"] = _generos;
            ViewData["distribuidores"] = _distribuidores;
            ViewData["desarrolladores"] = _desarrolladores;

            
            return View();
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            dynamic juego = _traductor.Get("https://localhost:44335/api/juegos/" + id.ToString());
            juegos juegoVista = new juegos();

            juegoVista.juego_id = juego.juego_id;
            juegoVista.titulo = juego.titulo;
            juegoVista.fecha_lanzamiento = juego.fecha_lanzamiento;
            juegoVista.imagen = juego.imagen;
            juegoVista.distribuidor_id = juego.distribuidor_id;
            juegoVista.desarrollador_id = juego.desarrollador_id;

            dynamic genero = _traductor.Get("https://localhost:44335/api/generos/" + juego.genero_id);
            juegoVista.genero_nombre = genero.genero_descripcion;

            dynamic desarrollador = _traductor.Get("https://localhost:44335/api/desarrolladores/" + juego.desarrollador_id);
            juegoVista.dessarrollador_nombre = desarrollador.desarrollador_razonsocial;

            dynamic distribuidor = _traductor.Get("https://localhost:44335/api/distribudores/" + juego.distribuidor_id);
            juegoVista.distribudor_nombre = distribuidor.distribuidor_razonsocial;


            ViewData["juego"] = juegoVista;

            return View();
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
