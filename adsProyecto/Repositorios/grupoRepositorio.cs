using adsProyecto.Interfaces;
using adsProyecto.Models;

namespace adsProyecto.Repositorios
{
    public class grupoRepositorio: IGrupo
    {
        private List<Grupo> lstGrupo = new List<Grupo>
        {
            new Grupo { IdGrupo = 1, IdCarrera = 1, IdMateria = 1, IdProfesor = 1, cliclo = "Enero-Junio", anio = "2021" },
        };
        public int AgregarGrupo(Grupo Grupo)
        {
            try
            {
                if (lstGrupo.Count > 0)
                {
                    Grupo.IdGrupo = lstGrupo.Last().IdGrupo + 1;
                }
                lstGrupo.Add(Grupo);
                return Grupo.IdGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Grupo ConsultarGrupoPorID(int idGrupo)
        {
            try
            {
                if (lstGrupo.Count > 0)
                {
                    Grupo Grupo = lstGrupo.Find(temp => temp.IdGrupo == idGrupo);
                    return Grupo;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Grupo> ConsultarGrupo()
        {
            try
            {
                return lstGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarGrupo(int idGrupo)
        {
            try
            {
                int index = lstGrupo.FindIndex(temp => temp.IdGrupo == idGrupo);
                lstGrupo.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ModificarGrupo(int idGrupo, Grupo Grupo)
        {
            try
            {
                int index = lstGrupo.FindIndex(temp => temp.IdGrupo == idGrupo);
                if (index != -1)
                {
                    lstGrupo[index] = Grupo;
                    lstGrupo[index].IdGrupo = idGrupo;
                    return idGrupo;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
