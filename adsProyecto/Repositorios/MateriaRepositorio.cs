using adsProyecto.Interfaces;
using adsProyecto.Models;

namespace adsProyecto.Repositorios
{
    public class MateriaRepositorio : IMaterias
    {
        private List<Materias> lstMaterias = new List<Materias>
        {
            new Materias { IdMateria = 1, nombreMateria = "Matematicas" }
        };
        public int AgregarMateria(Materias materia)
        {
            try
            {
                if (lstMaterias.Count > 0)
                {
                    materia.IdMateria = lstMaterias.Last().IdMateria + 1;
                }
                lstMaterias.Add(materia);
                return materia.IdMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Materias ConsultarMateriaPorID(int idMateria)
        {
            try
            {
                if (lstMaterias.Count > 0)
                {
                    Materias materia = lstMaterias.Find(temp => temp.IdMateria == idMateria);
                    return materia;
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

        public List<Materias> ConsultarMaterias()
        {
            try
            {
                return lstMaterias;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                int index = lstMaterias.FindIndex(temp => temp.IdMateria == idMateria);
                lstMaterias.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ModificarMateria(int idMateria, Materias materia)
        {
            try
            {
                int index = lstMaterias.FindIndex(temp => temp.IdMateria == idMateria);
                if (index != -1)
                {
                    lstMaterias[index] = materia;
                    lstMaterias[index].IdMateria = idMateria;
                    return idMateria;
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
