using adsProyecto.Interfaces;
using adsProyecto.Models;

namespace adsProyecto.Repositorios
{
    public class profesorRepositorio : IProfesor
    {
        private List<Profesor> lstProfesores = new List<Profesor>
        {
            new Profesor { IdProfesor = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Correo = "hola@gmail"}
        };
        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                if (lstProfesores.Count > 0)
                {
                    profesor.IdProfesor = lstProfesores.Last().IdProfesor + 1;
                }
                lstProfesores.Add(profesor);
                return profesor.IdProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Profesor> ConsultarProfesores()
        {
            try
            {
                return lstProfesores;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Profesor ConsultarProfesorPorID(int idProfesor)
        {
            try
            {
                Profesor profesor = lstProfesores.Find(temp => temp.IdProfesor == idProfesor);
                return profesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                int index = lstProfesores.FindIndex(temp => temp.IdProfesor == idProfesor);
                lstProfesores.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ModificarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                int index = lstProfesores.FindIndex(temp => temp.IdProfesor == idProfesor);
                if (index != -1)
                {
                    lstProfesores[index] = profesor;
                    lstProfesores[index].IdProfesor = idProfesor;
                    return idProfesor;
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
