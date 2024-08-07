using api.Models;
using api.Dtos.Comment;

namespace api.Interfaces {
  public interface ICommentRepository {
    Task<List<Comment>> GetAllAsync();
    Task<Comment?> GetByIdAsync(int id);
    Task<Comment> CreateAsync(Comment commentModel);
    Task<Comment?> DeleteAsync(int id);
  }
}