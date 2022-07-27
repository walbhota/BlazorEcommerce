using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id =1,
                Title = "The Hitchhiker's Guide to the Galaxy1",
                Description = " the series follows the adventures of Arthur Dent, a hapless Englishman, following the destruction of the Earth by the Vogons (a race of unpleasant and bureaucratic aliens) to make way for an intergalactic bypass. Dent's adventures intersect with several other characters: Ford Prefect (an alien and researcher for the eponymous guidebook who rescues Dent from Earth's destruction), Zaphod Beeblebrox (Ford's eccentric semi-cousin and the Galactic President who has stolen the Heart of Gold — a spacecraft equipped with Infinite Improbability Drive), the depressed robot Marvin the Paranoid Android, and Trillian (formerly known as Tricia McMillan) who is a woman Arthur once met at a party in Islington and who — thanks to Beeblebrox's intervention — is the only other human survivor of Earth's destruction.In their travels, Arthur comes to learn that the Earth was actually a giant supercomputer, created by another supercomputer, Deep Thought. Deep Thought had been built by its creators to give the answer to the \"Ultimate Question of Life, the Universe, and Everything\", which, after eons of calculations, was given simply as \"42\". Deep Thought was then instructed to design the Earth supercomputer to determine what the Question actually is. The Earth was subsequently destroyed by the Vogons moments before its calculations were completed, and Arthur becomes the target of the descendants of the Deep Thought creators, believing his mind must hold the Question. With his friends' help, Arthur escapes and they decide to have lunch at The Restaurant at the End of the Universe, before embarking on further adventures.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id =2,
                Title = "Ready Player One",
                Description = "In the 2040s, the world has been gripped by an energy crisis from the depletion of fossil fuels and the consequences of pollution, global warming and overpopulation, causing widespread social problems, poverty, and economic stagnation. To escape the decline their world is facing, people turn to the OASIS,[a] a virtual reality simulator accessible by players using visors and haptic technology such as gloves. It functions both as an MMORPG and as a virtual world, with its currency being the most stable in the real world. It was created by James Donovan Halliday, founder of Gregarious Simulation Systems (formerly Gregarious Games), who made a posthumous video of his will stating to the public that he had left an Easter egg inside the OASIS, and the first person to find it would inherit his entire fortune, ownership of his corporation as well as complete control of the OASIS itself, which is worth trillions. The story follows the adventures of Wade Watts, starting about five years after the announcement, when he discovers one of the three keys which unlock three successive gates leading to the treasure",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Ready_Player_One_cover.jpg/220px-Ready_Player_One_cover.jpg",
                Price = 8.99m
            },
            new Product
            {
                Id =3,
                Title = "Nineteen Eighty-Four",
                Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society. Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany. More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg",
                Price = 7.99m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
