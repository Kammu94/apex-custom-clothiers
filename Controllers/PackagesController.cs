using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApexCustomClothiers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private static List<Package> packages = new List<Package>();

        // GET: api/packages
        [HttpGet]
        public ActionResult<IEnumerable<Package>> GetPackages()
        {
            return Ok(packages);
        }

        // GET: api/packages/{id}
        [HttpGet("{id}")]
        public ActionResult<Package> GetPackage(int id)
        {
            var package = packages.FirstOrDefault(p => p.Id == id);
            if (package == null)
            {
                return NotFound();
            }
            return Ok(package);
        }

        // POST: api/packages
        [HttpPost]
        public ActionResult<Package> CreatePackage(Package package)
        {
            package.Id = packages.Count + 1;
            packages.Add(package);
            return CreatedAtAction(nameof(GetPackage), new { id = package.Id }, package);
        }

        // PUT: api/packages/{id}
        [HttpPut("{id}")]
        public IActionResult UpdatePackage(int id, Package package)
        {
            var existingPackage = packages.FirstOrDefault(p => p.Id == id);
            if (existingPackage == null)
            {
                return NotFound();
            }
            existingPackage.Name = package.Name;
            existingPackage.Price = package.Price;
            // Update other properties as necessary
            return NoContent();
        }

        // DELETE: api/packages/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePackage(int id)
        {
            var package = packages.FirstOrDefault(p => p.Id == id);
            if (package == null)
            {
                return NotFound();
            }
            packages.Remove(package);
            return NoContent();
        }
    }

    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Other relevant properties
    }
}