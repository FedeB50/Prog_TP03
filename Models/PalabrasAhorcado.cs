namespace ActBD.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;
    public PalabrasAhorcado()
    {
        DB bdAhorcado = new DB();
        palabras = bdAhorcado.traerPalabras();
    }
    public string ObtenerPalabra()
    {
        Random random = new Random();
        int i = random.Next(palabras.Count);
        return palabras[i];
    }
}

