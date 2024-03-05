using Dự_án_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class AccountService
    {
        public static List<accountService> GetAccount()
        {
            List<accountService> account = new List<accountService>();

            string[] datas = File.ReadAllLines("account.txt");
            foreach (string data in datas)
            {
                if (!string.IsNullOrEmpty(data))
                {
                    string[] thuoctinhs = data.Split('|');
                    string name = thuoctinhs[0];
                    string id = thuoctinhs[1];
                    string email = thuoctinhs[2];
                    string tentaikhoan = thuoctinhs[3];
                    string matkhau = thuoctinhs[4];
                    string xnmk = thuoctinhs[5];

                    accountService accountt = new accountService(name,id,email,tentaikhoan,matkhau,xnmk);
                    account.Add(accountt);
                }

            }
            return account;
        }
        public static accountService CheckLogin(string username, string password)
        {
            var allAccounts = GetAccount();
            var check = allAccounts.FirstOrDefault(p => p.Tentaikhoan == username && p.Matkau == password);
            return check;
        }
    }
}
