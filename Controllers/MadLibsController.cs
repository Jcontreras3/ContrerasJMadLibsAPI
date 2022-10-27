//Jovann Contreras
//Date 10/26/2022
//Peer reviewed by: Brandon Le - Mad Lib worked properly and all inputs linked to the correct part of the story. There were some spacing issues that he will fix and other than that it works well and also the story is fun and creative. Good job overall! I liked how his inputs were not in the URL. Very cool.

using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mad.Models;

namespace ContrerasJMadLibsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibsController : ControllerBase
    {
        
       [HttpGet]
       [Route("MadLibsApi")] 

       public string MadLibsChallenge(MadModels item)
       {
             return $"The {item.adj} day was a hard day for {item.fictionalCreature}, {item.heOrshe} got up to go to a {item.specialEvent} at th{item.location} but {item.heOrshe} had to go and get {item.food}. Walking down the side walk {item.heOrshe} had seen their favorite {item.noun} in their favorite {item.color}. Continuing on {item.heOrshe} made it down to the {item.adjTwo} resturant they {item.adverb} inside and grabbed the food. {item.heOrshe} made it to the {item.specialEvent} and was happy The End. ";
       }
    }
}