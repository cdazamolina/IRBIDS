using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaitingTTS.Models;

namespace RaitingTTS
{
    public class Database
    {
        public List<User> GetUsers() {
            List<User> users;
            using (var context = new IRBIDSContext())
            {
                users = context.User.ToList();
            }
            return users;
        }
        public List<Attempt> GetAttempts() {
            List<Attempt> attempts;
            using (var context = new IRBIDSContext())
            {
                attempts = context.Attempt.ToList();
            }
            return attempts;
        }
    }
}
