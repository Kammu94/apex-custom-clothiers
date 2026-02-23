using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Controllers
{
    [Route("api/[controller]")]  
    [ApiController]
    public class ContactController : ControllerBase
    {
        // Replace with your actual data storage (e.g., database, in-memory list, etc.)
        private static List<ContactFormSubmission> submissions = new List<ContactFormSubmission>();

        // POST: api/contact/submit
        [HttpPost("submit")]
        public IActionResult SubmitContactForm([FromBody] ContactFormSubmission submission)
        {
            submissions.Add(submission);
            return CreatedAtAction(nameof(GetSubmissionById), new { id = submission.Id }, submission);
        }

        // GET: api/contact
        [HttpGet]
        public ActionResult<IEnumerable<ContactFormSubmission>> GetAllSubmissions()
        {
            return Ok(submissions);
        }

        // GET: api/contact/{id}
        [HttpGet("{id}")]
        public ActionResult<ContactFormSubmission> GetSubmissionById(int id)
        {
            var submission = submissions.Find(s => s.Id == id);
            if (submission == null)
            {
                return NotFound();
            }
            return Ok(submission);
        }

        // DELETE: api/contact/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteSubmission(int id)
        {
            var submission = submissions.Find(s => s.Id == id);
            if (submission == null)
            {
                return NotFound();
            }
            submissions.Remove(submission);
            return NoContent();
        }
    }

    public class ContactFormSubmission
    {
        public int Id { get; set; } // Unique ID for submission, implement logic to auto-generate
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}