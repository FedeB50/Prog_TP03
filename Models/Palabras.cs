namespace TP03.Models
{
    public class PalabrasAhorcado
    {
        private List<string> palabras;
        public PalabrasAhorcado()
        {
            palabras = new List<string> {"ALMOHADA","ESQUI","SUBRAYAR","CANGREJO","IZQUIERDO","PIZPIRETA","WHISKERIA","HEXAGONO","ZIZAGUEAR","GNOMON"};
        }
        public string ObtenerPalabra()
        {
            Random random = new Random();
            int i = random.Next(palabras.Count);
            return palabras[i];
        }
    }
}
