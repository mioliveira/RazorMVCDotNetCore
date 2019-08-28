namespace RazorMVCDotNetCore.Models.Artigo
{
    public class ArtigoTemaModel
    {
        public long Codigo { get; set; }
        public ArtigoModel Artigo { get; set; }
        public int Qtd { get; set; }

        public ArtigoTemaModel()
        {
            Artigo = new ArtigoModel();
        }
    }
}
