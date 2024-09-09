using appIngles.Models;

namespace appIngles.Negocio
{
    public class PalabraNeg
    {

         public void Buscar(int idUsuario,ref List<Palabra> lisPalabra, ref string codError, ref string menError)
        {
            Palabras datPalabra = new Palabras();
         

            datPalabra.Buscar(idUsuario,ref lisPalabra, ref codError, ref menError);

            
        }
    }
}
