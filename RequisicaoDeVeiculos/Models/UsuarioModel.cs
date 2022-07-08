namespace RequisicaoDeVeiculos.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string Usuario { get; set; }
        
        public string Senha { get; set; }   

        public int Permissao { get; set; }
    }
}
