using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository {
    public class CommentRepository : ICommentRepository
    {
         private readonly ApplicationDBContext _context;
         public CommentRepository(ApplicationDBContext context){
            _context = context;
         }

        public Task<Comment> CreateAsync(Comment commentModel)
        {
            throw new NotImplementedException();
        }

        public Task<Comment?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetAllAsync()
        {
            return _context.Comments.ToListAsync();
        }

        public Task<Comment?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}