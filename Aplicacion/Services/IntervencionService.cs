﻿using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class IntervencionService : IIntervencionService
    {
        private readonly IIntervencionRepository _intervecnionRepository;

        public IntervencionService(IIntervencionRepository intervecnionRepository)
        {
            this._intervecnionRepository = intervecnionRepository;
        }

        public Intervencion CreateIntervencion(string Descripcion, int TicketID, int EstadoIntervencionID, int TipoIntervencionID)
        {
            var intervencion = new Intervencion(Descripcion, TicketID, EstadoIntervencionID, TipoIntervencionID);
            _intervecnionRepository.CreateIntervencion(intervencion);
            return intervencion;
        }

        public Intervencion DeleteIntervencion(int id)
        {
            var intervencion = _intervecnionRepository.GetIntervencion(id);
            return _intervecnionRepository.DeleteIntervencion(intervencion);
        }

        public Intervencion GetIntervencion(int id)
        {
            //return _intervecnionRepository.GetIntervencion(id);
            Intervencion test = new("Prueba", 1, 1,1);
            return test;
        }

        public List<Intervencion> GetIntervenciones()
        {
            return _intervecnionRepository.GetIntervenciones();
        }

        public List<Intervencion> GetIntervencionesByFabrica(int FabricaID)
        {
            return _intervecnionRepository.GetIntervencionesByFabrica(FabricaID);
        }

        public List<Intervencion> GetIntervencionesByLinea(int LineaID)
        {
            return _intervecnionRepository.GetIntervencionesByLinea(LineaID);
        }

        public List<Intervencion> GetIntervencionesByMaquina(int MaquinaID)
        {
            return _intervecnionRepository.GetIntervencionesByMaquina(MaquinaID);
        }

        public List<Intervencion> GetIntervencionesByTipoIntervencion(int TipoIntervencionID)
        {
            return _intervecnionRepository.GetIntervencionesByTipoIntervencion(TipoIntervencionID);
        }

        public Intervencion UpdateIntervencion(int id, string Descripcion, int TicketID, int EstadoIntervencionID, int TipoIntervencionID)
        {
            var newIntervencion = _intervecnionRepository.GetIntervencion(id);
            newIntervencion.Descripcion = Descripcion;
            newIntervencion.TicketID = TicketID;
            newIntervencion.EstadoIntervencionID = EstadoIntervencionID;
            newIntervencion.TipoIntervencionID = TipoIntervencionID;

            return _intervecnionRepository.UpdateIntervencion(newIntervencion);
        }
    }
}
