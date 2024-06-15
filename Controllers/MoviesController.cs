using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesFinal1406.Models;

namespace MoviesFinal1406.Controllers
{

    
    public class MoviesController : Controller
    {
        private readonly MovieContext _context; // Контекст базы данных для работы с фильмами

        // Конструктор контроллера, принимает контекст базы данных через внедрение зависимостей
        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
           
            if (id == null)
            {
                return NotFound(); 
            }

           
            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
           
            if (movie == null)
            {
                return NotFound(); 
            }

           
            return View(movie);
        }

        
        public IActionResult Create()
        {
            return View(); 
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Director,Genre,Year,PosterPath,Description")] Movie movie)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(movie); 
                await _context.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index)); 
            }
            return View(movie);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();  
            }

            
            var movie = await _context.Movies.FindAsync(id);
            
            if (movie == null)
            {
                return NotFound(); 
            }
            return View(movie); 
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Director,Genre,Year,PosterPath,Description")] Movie movie)
        {
           
            if (id != movie.Id)
            {
                return NotFound(); 
            }

            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync(); 
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw; 
                    }
                }
                return RedirectToAction(nameof(Index)); 
            }
            return View(movie); 
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            
            if (id == null)
            {
                return NotFound(); 
            }

          
            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
          
            if (movie == null)
            {
                return NotFound(); 
            }

            return View(movie); 
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        { 
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound(); 
            }

            _context.Movies.Remove(movie); 
            await _context.SaveChangesAsync(); 
            return RedirectToAction(nameof(Index)); 
        }

        
        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
