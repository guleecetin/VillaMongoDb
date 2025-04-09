using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace Villa.Entity.Entities
{
    public class UserLogin:IdentityUserLogin<ObjectId>
    {
    }
}
