using System;
using System.Collections.Generic;
using System.Linq;

namespace gosti2
{
    public static class UserManager
    {
        private static List<User> users = new List<User>();

        // Adiciona um novo usuário
        public static void AddUser(User newUser)
        {
            if (users.Any(u => u.Email == newUser.Email))
            {
                throw new InvalidOperationException("Este e-mail já está cadastrado!");
            }

            users.Add(newUser);
        }

        // Valida o login do usuário
        public static bool ValidateLogin(string email, string password)
        {
            return users.Exists(u => u.Email == email && u.Senha == password);
        }

        // Verifica se e-mail já existe
        public static bool EmailExists(string email)
        {
            return users.Any(u => u.Email == email);
        }

        // Obtém todos os usuários (útil para debug)
        public static List<User> GetAllUsers()
        {
            return new List<User>(users);
        }

        // Remove um usuário pelo e-mail
        public static bool RemoveUser(string email)
        {
            var user = users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                users.Remove(user);
                return true;
            }
            return false;
        }
    }
}