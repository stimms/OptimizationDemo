using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using OptimizationDemo.Models;
using System.Dynamic;

namespace OptimizationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("BigCookie", @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ut lobortis quam. Vivamus sit amet laoreet tortor. Phasellus quis pulvinar nibh, id ullamcorper justo. Nulla vehicula dolor ut tempus iaculis. Quisque non urna fringilla, molestie odio id, convallis felis. Sed sed neque vehicula, elementum libero sed, adipiscing orci. Phasellus porta nulla tellus, a semper lectus tempor eu. Aenean sagittis pretium lobortis. Curabitur egestas neque sit amet bibendum cursus. Suspendisse quis libero luctus, accumsan nunc quis, interdum ante. Phasellus vitae blandit elit. Quisque egestas lacus eu tortor pulvinar consequat. In hac habitasse platea dictumst. Curabitur molestie dui faucibus orci vulputate, in malesuada nibh mollis.Nullam erat nibh, commodo id mi fermentum, pharetra porta sem. Maecenas eu sem sed mauris tristique egestas vel eu turpis. Proin ut consequat massa. Suspendisse arcu urna, blandit non placerat eget, auctor vel mi. Ut augue elit, auctor vitae congue sit amet, sagittis vehicula eros. Vestibulum semper nisl a justo posuere ullamcorper. Nam tincidunt neque lorem, eget iaculis velit viverra ac. Donec eu lectus dui. Suspendisse et tortor non purus elementum suscipit. Vestibulum in tellus vitae velit feugiat feugiat et non tellus. Nulla lorem tortor, feugiat non odio id, fringilla imperdiet diam. Etiam ultrices eros condimentum turpis iaculis scelerisque.Fusce aliquet dolor vitae molestie laoreet. Nunc interdum tortor lobortis ligula porta iaculis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras varius, nisl ac porttitor hendrerit, tellus nisi pharetra sapien, quis placerat quam mi sed dolor. Morbi dolor tellus, tincidunt in varius varius, semper a leo. Donec mattis sem magna, ac euismod enim faucibus a. Integer ultrices, quam ac vestibulum dapibus, elit enim condimentum quam, non faucibus turpis neque commodo lorem. Vestibulum egestas arcu turpis, at imperdiet ipsum elementum a. Ut risus lorem, vulputate eget cursus nec, venenatis eu lorem. Nunc massa nibh, sagittis ac diam sit amet, euismod congue velit. Nam pharetra metus vitae feugiat rhoncus. Mauris viverra tortor elit, sed vestibulum mauris laoreet id. Ut ultrices in lectus non tristique. Sed vitae malesuada elit, quis vestibulum ante. Sed feugiat nunc at metus tincidunt, vitae molestie mauris posuere. Quisque nisi quam, tempor sit amet sapien eu, semper interdum leo.Maecenas a urna sed quam sagittis aliquam. Nunc condimentum malesuada risus eu blandit. Suspendisse mollis nec risus non imperdiet. Curabitur volutpat, felis non elementum accumsan, purus erat hendrerit sapien, rhoncus adipiscing nisi tellus vel nibh. Duis ac purus mauris. Nullam id iaculis dolor. Fusce a aliquet magna. Cras feugiat, eros at accumsan feugiat, neque purus elementum lectus, et porta nisi massa luctus lacus. Curabitur sed semper diam, ut facilisis metus. Quisque rhoncus malesuada sem, ac sodales sapien. Nullam sit amet sem orci. Pellentesque venenatis enim libero, a posuere massa convallis ut. Duis ornare tortor in vehicula rutrum. Sed sed neque ultrices libero aliquam pretium.Duis sed molestie est. Cras at convallis leo. Proin eget dictum diam. Aenean adipiscing facilisis turpis sit amet interdum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean vel nisi commodo, mattis lorem non, vulputate est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec feugiat rutrum eros ac semper. Quisque iaculis porttitor erat, sit amet sagittis nisi consequat nec. In et euismod ante.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ut lobortis quam. Vivamus sit amet laoreet tortor. Phasellus quis pulvinar nibh, id ullamcorper justo. Nulla vehicula dolor ut tempus iaculis. Quisque non urna fringilla, molestie odio id, convallis felis. Sed sed neque vehicula, elementum libero sed, adipiscing orci. Phasellus porta nulla tellus, a semper lectus tempor eu. Aenean sagittis pretium lobortis. Curabitur egestas neque sit amet bibendum cursus. Suspendisse quis libero luctus, accumsan nunc quis, interdum ante. Phasellus vitae blandit elit. Quisque egestas lacus eu tortor pulvinar consequat. In hac habitasse platea dictumst. Curabitur molestie dui faucibus orci vulputate, in malesuada nibh mollis.Nullam erat nibh, commodo id mi fermentum, pharetra porta sem. Maecenas eu sem sed mauris tristique egestas vel eu turpis. Proin ut consequat massa. Suspendisse arcu urna, blandit non placerat eget, auctor vel mi. Ut augue elit, auctor vitae congue sit amet, sagittis vehicula eros. Vestibulum semper nisl a justo posuere ullamcorper. Nam tincidunt neque lorem, eget iaculis velit viverra ac. Donec eu lectus dui. Suspendisse et tortor non purus elementum suscipit. Vestibulum in tellus vitae velit feugiat feugiat et non tellus. Nulla lorem tortor, feugiat non odio id, fringilla imperdiet diam. Etiam ultrices eros condimentum turpis iaculis scelerisque.Fusce aliquet dolor vitae molestie laoreet. Nunc interdum tortor lobortis ligula porta iaculis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras varius, nisl ac porttitor hendrerit, tellus nisi pharetra sapien, quis placerat quam mi sed dolor. Morbi dolor tellus, tincidunt in varius varius, semper a leo. Donec mattis sem magna, ac euismod enim faucibus a. Integer ultrices, quam ac vestibulum dapibus, elit enim condimentum quam, non faucibus turpis neque commodo lorem. Vestibulum egestas arcu turpis, at imperdiet ipsum elementum a. Ut risus lorem, vulputate eget cursus nec, venenatis eu lorem. Nunc massa nibh, sagittis ac diam sit amet, euismod congue velit. Nam pharetra metus vitae feugiat rhoncus. Mauris viverra tortor elit, sed vestibulum mauris laoreet id. Ut ultrices in lectus non tristique. Sed vitae malesuada elit, quis vestibulum ante. Sed feugiat nunc at metus tincidunt, vitae molestie mauris posuere. Quisque nisi quam, tempor sit amet sapien eu, semper interdum leo.Maecenas a urna sed quam sagittis aliquam. Nunc condimentum malesuada risus eu blandit. Suspendisse mollis nec risus non imperdiet. Curabitur volutpat, felis non elementum accumsan, purus erat hendrerit sapien, rhoncus adipiscing nisi tellus vel nibh. Duis ac purus mauris. Nullam id iaculis dolor. Fusce a aliquet magna. Cras feugiat, eros at accumsan feugiat, neque purus elementum lectus, et porta nisi massa luctus lacus. Curabitur sed semper diam, ut facilisis metus. Quisque rhoncus malesuada sem, ac sodales sapien. Nullam sit amet sem orci. Pellentesque venenatis enim libero, a posuere massa convallis ut. Duis ornare tortor in vehicula rutrum. Sed sed neque ultrices libero aliquam pretium.Duis sed molestie est. Cras at convallis leo. Proin eget dictum diam. Aenean adipiscing facilisis turpis sit amet interdum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean vel nisi commodo, mattis lorem non, vulputate est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec feugiat rutrum eros ac semper. Quisque iaculis porttitor erat, sit amet sagittis nisi consequat nec. In et euismod ante.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ut lobortis quam. Vivamus sit amet laoreet tortor. Phasellus quis pulvinar nibh, id ullamcorper justo. Nulla vehicula dolor ut tempus iaculis. Quisque non urna fringilla, molestie odio id, convallis felis. Sed sed neque vehicula, elementum libero sed, adipiscing orci. Phasellus porta nulla tellus, a semper lectus tempor eu. Aenean sagittis pretium lobortis. Curabitur egestas neque sit amet bibendum cursus. Suspendisse quis libero luctus, accumsan nunc quis, interdum ante. Phasellus vitae blandit elit. Quisque egestas lacus eu tortor pulvinar consequat. In hac habitasse platea dictumst. Curabitur molestie dui faucibus orci vulputate, in malesuada nibh mollis.Nullam erat nibh, commodo id mi fermentum, pharetra porta sem. Maecenas eu sem sed mauris tristique egestas vel eu turpis. Proin ut consequat massa. Suspendisse arcu urna, blandit non placerat eget, auctor vel mi. Ut augue elit, auctor vitae congue sit amet, sagittis vehicula eros. Vestibulum semper nisl a justo posuere ullamcorper. Nam tincidunt neque lorem, eget iaculis velit viverra ac. Donec eu lectus dui. Suspendisse et tortor non purus elementum suscipit. Vestibulum in tellus vitae velit feugiat feugiat et non tellus. Nulla lorem tortor, feugiat non odio id, fringilla imperdiet diam. Etiam ultrices eros condimentum turpis iaculis scelerisque.Fusce aliquet dolor vitae molestie laoreet. Nunc interdum tortor lobortis ligula porta iaculis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras varius, nisl ac porttitor hendrerit, tellus nisi pharetra sapien, quis placerat quam mi sed dolor. Morbi dolor tellus, tincidunt in varius varius, semper a leo. Donec mattis sem magna, ac euismod enim faucibus a. Integer ultrices, quam ac vestibulum dapibus, elit enim condimentum quam, non faucibus turpis neque commodo lorem. Vestibulum egestas arcu turpis, at imperdiet ipsum elementum a. Ut risus lorem, vulputate eget cursus nec, venenatis eu lorem. Nunc massa nibh, sagittis ac diam sit amet, euismod congue velit. Nam pharetra metus vitae feugiat rhoncus. Mauris viverra tortor elit, sed vestibulum mauris laoreet id. Ut ultrices in lectus non tristique. Sed vitae malesuada elit, quis vestibulum ante. Sed feugiat nunc at metus tincidunt, vitae molestie mauris posuere. Quisque nisi quam, tempor sit amet sapien eu, semper interdum leo.Maecenas a urna sed quam sagittis aliquam. Nunc condimentum malesuada risus eu blandit. Suspendisse mollis nec risus non imperdiet. Curabitur volutpat, felis non elementum accumsan, purus erat hendrerit sapien, rhoncus adipiscing nisi tellus vel nibh. Duis ac purus mauris. Nullam id iaculis dolor. Fusce a aliquet magna. Cras feugiat, eros at accumsan feugiat, neque purus elementum lectus, et porta nisi massa luctus lacus. Curabitur sed semper diam, ut facilisis metus. Quisque rhoncus malesuada sem, ac sodales sapien. Nullam sit amet sem orci. Pellentesque venenatis enim libero, a posuere massa convallis ut. Duis ornare tortor in vehicula rutrum. Sed sed neque ultrices libero aliquam pretium.Duis sed molestie est. Cras at convallis leo. Proin eget dictum diam. Aenean adipiscing facilisis turpis sit amet interdum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean vel nisi commodo, mattis lorem non, vulputate est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec feugiat rutrum eros ac semper. Quisque iaculis porttitor erat, sit amet sagittis nisi consequat nec. In et euismod ante.");
            HttpContext.Response.Cookies.Add(cookie);
            return View();
        }

        public ActionResult QueryExamples()
        {
            using(var context = new ApplicationDbContext())
            {
                var iceCreams = context.IceCreams;

                dynamic model = new ExpandoObject();
                model.IceCreams = iceCreams.ToList();
                return View(model);
            }
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #region Generate Data
        public ActionResult CreateData()
        {
            var vendors = new String[] { "Baskin-Robbins",
"Ben & Jerry's",
"Blue Bell Creameries",
"Blue Bunny",
"Bomb Pop",
"Braum's",
"Brigham's",
"Bruster's",
"Bulla Dairy Foods",
"Bico",
"Breyer's",
"Bulla",
"Cadwalader's Ice Cream",
"Campina",
"Carvel",
"Chapman's",
"Chocolate Shoppe Ice Cream Company",
"Ciao Bella",
"Cold Stone Creamery",
"Coppelia (ice cream parlor)",
"Culver's",
"Dairy Queen",
"D'Onofrio",
"Double Rainbow",
"Dreyer's",
"Dippin Dots",
"Drumsticks",
"Edy's",
"Foster Farms",
"Freaky Ice",
"Friendly's",
"Fudgsicle"};
            var flavours = new String[]{"Banana Split",
"Boston Cream Pie",
"Cinnamon Bunn",
"Coffee Heath Bar Crunch",
"Créme Brulée",
"Chocolate Chip Cook Dough",
"Chocolate Fudge Brownie",
"Brownie Batter",
"Cake Batter",
"Cheesecake Brownie",
"Chubby Hubby",
"Magic Brownies",
"Dublin Mudslide",
"Mint CHocolate Chunk",
"Peanut Brittle Maple Blonde",
"Peanut Butter Cup",
"Mud Pie",
"Karamel Suite",
"Cherry Garcia",
"Vanilla",
"Chocolate",
"Natural Vanilla",
"Rocky Road",
"Peach",
"Extra Creamy Chocolate",
"Vanilla Fudge Brownie",
"Cherry Vanilla",
"Chocolate",
"Chocolate CHip",
"Vanilla Fudge Twirl",
"French Vanilla",
"Extra Creamy Vanilla",
"Chocolate Crackle",
"Chocolate Chip Cookie Dough",
"Triple Chocolate",
"Vanilla, Chocolate, Strawberry",
"Butter Pecan",
"Premium Banana Pecan",
"Premium Banana Split Ice Cream",
"Premium Black Walnut",
"Premium Bordeaux Cherry Amaretto",
"Premium Brownie Batter",
"Premium Brownie Fudge Sundae",
"Premium Butter Brickle",
"Premium Butter Pecan",
"Premium Cake Batter",
"Premium Cappuccino Chunky Chocolate",
"Premium Cherries Pecans & Cream",
"Premium Cherry Chocolate Chip",
"Premium Chocolate",
"Premium Chocolate Almond",
"Premium Chocolate Chip",
"Premium Chocolate Chip Chocolate",
"Premium Chocolate Chip Cookie Dough",
"Premium Chocolate Malt Ball",
"Premium Chocolate Marshmallow",
"Premium Chocolate Pecan",
"Premium Chocolate Toffee",
"Premium Cookies ‘n’ Cream",
"Premium Double Chocolate Chip Cookie Dough",
"Premium Dream Cooler",
"Premium Dulce de Leche",
"Premium English Toffee",
"Premium Fudge Ripple",
"Premium German Chocolate",
"Premium Gingerbread – Seasonal",
"Premium Homestyle Vanilla",
"Premium Mint Chocolate Chip",
"Premium Neapolitan",
"Premium Peanut Butter Cup",
"Premium Peanut Butter with Snickers",
"Premium Pecans Pralines & Cream",
"Premium Peppermint",
"Premium Pistachio Almond",
"Premium Pumpkin-Seasonal",
"Premium Rocky Road",
"Premium Strawberry",
"Premium Strawberry Cheesecake",
"Premium Vanilla",
"Premium Vanilla Bean",
"Premium Vanilla Chunky Chocolate",
"Premium Vanilla with Butterfinger",
"Premium White Chocolate Raspberry Cheesecake"};
            var ingredients = new string[]{
                "acesulfame-K (acesulfame potassium)",
"acetylated esters of mono- and diglycerides",
"ammonium chloride",
"artificial colors",
"artificial flavors",
"aspartame",
"azodicarbonamide",
"benzoates in food",
"benzoyl peroxide",
"BHA (butylated hydroxyanisole)",
"BHT (butylated hydroxytoluene)",
"bleached flour",
"bromated flour",
"brominated vegetable oil (BVO)",
"calcium bromate",
"calcium disodium EDTA",
"calcium peroxide",
"calcium propionate",
"calcium saccharin",
"calcium sorbate",
"calcium stearoyl-2-lactylate",
"caprocaprylobehenin",
"carmine",
"certified colors",
"cyclamates",
"cysteine (l-cysteine), as an additive for bread products",
"DATEM (Diacetyl tartaric and fatty acid esters of mono and diglycerides)",
"dimethylpolysiloxane",
"dioctyl sodium sulfosuccinate (DSS)",
"disodium calcium EDTA",
"disodium dihydrogen EDTA",
"disodium guanylate",
"disodium inosinate",
"EDTA",
"ethyl vanillin",
"ethylene oxide",
"ethoxyquin",
"FD & C colors",
"foie gras",
"GMP (disodium guanylate)",
"hexa-, hepta- and octa-esters of sucrose",
"high fructose corn syrup",
"hydrogenated fats",
"IMP (disodium inosinate)",
"irradiated foods",
"lactylated esters of mono- and diglycerides",
"lead soldered cans",
"methyl silicon",
"methylparaben",
"microparticularized whey protein derived fat substitute",
"monosodium glutamate (MSG)",
"natamycin",
"nitrates/nitrites",
"partially hydrogenated oil",
"polydextrose",
"potassium benzoate",
"potassium bromate",
"potassium sorbate",
"propionates",
"propyl gallate",
"propylparaben",
"saccharin",
"sodium aluminum sulfate",
"sodium benzoate",
"sodium diacetate",
"sodium glutamate",
"sodium nitrate/nitrite",
"sodium propionate",
"sodium stearoyl-2-lactylate",
"solvent extracted oils, as standalone single-ingredient oils (except grapeseed oil).",
"sorbic acid",
"sucralose",
"sucroglycerides",
"sucrose polyester",
"sulfites (except in wines, meads and ciders)",
"TBHQ (tertiary butylhydroquinone)",
"tetrasodium EDTA",
"vanillin"            };

            using (var db = new ApplicationDbContext())
            {
                foreach (var vendor in vendors)
                {
                    db.Vendors.Add(new Vendor { ManagerName = "Frank", PhoneNumber = "403.554.1234", Name = vendor });
                }
                Random randomNumber = new Random();
                foreach(var ingredient in ingredients)
                {
                    db.Ingredients.Add(new Ingredient { CaloriesPerUnit = randomNumber.NextDouble(), Quanity = randomNumber.NextDouble(), Name = ingredient });
                }
                db.SaveChanges();
                foreach (var flavour in flavours)
                {
                    var iceCream = new IceCream { Description = "A very yummy " + flavour, Name = flavour, Price = randomNumber.Next() };
                    for (int i = 0; i < randomNumber.Next(5, 20); i++)
                        iceCream.Ingredients.Add(db.Ingredients.Find(randomNumber.Next(1, ingredients.Length + 1)));
                    db.IceCreams.Add(iceCream);
                }

                db.SaveChanges();

                foreach (var vendor in db.Vendors)
                {
                    for (int i = 0; i < randomNumber.Next(5, 20); i++)
                        vendor.IceCreams.Add(db.IceCreams.Find(randomNumber.Next(1, flavours.Length + 1)));
                }
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}