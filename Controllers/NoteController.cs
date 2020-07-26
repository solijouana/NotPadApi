using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotePad_api.Models;

namespace NotePad_api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class NoteController : ControllerBase
    {
        private AppDbContext _context;
        public NoteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNote([FromRoute] string id)
        {
            if (ModelState.IsValid)
            {
                var note = await _context.Notes.FindAsync(id);
                if (note == null)
                {
                    return NotFound();
                }
                return Ok(note);

            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> PostNote([FromBody] Note note)
        {
            if (ModelState.IsValid)
            {
                note.CreateDate = DateTime.Now;
                _context.Notes.Add(note);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetNote", new { id = note.Id }, note);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditNote([FromRoute] string id, [FromBody] Note editNote)
        {
            if (ModelState.IsValid)
            {
                var note = await _context.Notes.FindAsync(id);
                if (note == null)
                    return NotFound();

                _context.Entry(editNote).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute] string id)
        {
            if (ModelState.IsValid)
            {
                var note = await _context.Notes.FindAsync(id);
                if (note == null)
                    return NotFound();

                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }
    }
}