using System;
using WebServiceAltamira.Models;
using WebServicesOperacional.DATA;

namespace WebServiceAltamira.BL
{

    public class Avisos
    {
        public Boolean PostAvisos(AvisosModel model)
        {
            
            using (var ejemplo = new DCOMEntities4())
            {
                var t = new DAvisos()
                {
                    CodGrupoAvisos = model.CodGrupoAvisos,
                    CodGrupo = model.CodGrupo,
                    CodTipoAviso = model.CodTipoAviso,
                    Icono = model.Icono,
                    FechaInicio = model.FechaInicio,
                    FechaFin = model.FechaFin,
                    Mensaje = model.Mensaje,
                    Nombre = model.Nombre,
                    Activo = model.Activo,
                    Html = model.Html,
                    IsCodigo = model.IsCodigo,

                };
                ejemplo.DAvisos.Add(t);
                try
                {
                    ejemplo.SaveChanges();
                    return true;
                } catch (Exception)
                {
                    return false;
                }
            }

        }
    }
}

