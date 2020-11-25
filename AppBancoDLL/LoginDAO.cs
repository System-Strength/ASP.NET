using AppBancoADO;
using AppBancoDominio;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace AppBancoDLL
{
    public class LoginDAO
    {
        private Banco db;
        public List<Login> Listar()
        {
            var db = new Banco();
            var strQuery = "select * from tbl_func";
            var retorno = db.retornaComando(strQuery);
            return listaLogin(retorno);
        }
        public Login ListarId(int id)
        {
            using (db = new Banco())
            {
                var strQuery = string.Format("select * from tbl_login where id_func = {0} ", id);
                var retorno = db.retornaComando(strQuery);
                return listaLogin(retorno).FirstOrDefault();
            }
        }
        private List<Login> listaLogin(MySqlDataReader retorno)
        {
            var funcionarios = new List<Login>();
            while (retorno.Read())
            {
                var TempLogin = new Login()
                {
                    id_func = int.Parse(retorno["id_func"].ToString()),
                    cpf_func = retorno["cpf_func"].ToString().Replace(".", string.Empty).Replace("-", string.Empty),
                };
                funcionarios.Add(TempLogin);
            }
            return funcionarios;
        }
    }
}