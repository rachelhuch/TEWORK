using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private string ConnectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string sql = "SELECT * from reviews";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Review review = new Review()
                    {
                        Username = Convert.ToString(rdr["username"]),
                        ReviewTitle = Convert.ToString(rdr["review_title"]),
                        Rating = Convert.ToInt32(rdr["rating"]),
                        ReviewText = Convert.ToString(rdr["review_text"])

                    };
                    reviews.Add(review);
                }
            }
            return reviews;
        }

        public int SaveReview(Review newReview)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>

    }
}



public int SaveReview(Review newReview)
{

    using (SqlConnection conn = new SqlConnection(ConnectionString))
    {
        conn.Open();

        string sql = "Insert INTO review (username, review_title, rating, review_text) Values (@username, @review_title, @rating, @review_text)";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@username", newReview.Username);
        cmd.Parameters.AddWithValue("@review_title", newReview.ReviewTitle);
        cmd.Parameters.AddWithValue("@rating", newReview.Rating);
        cmd.Parameters.AddWithValue("@review_text", newReview.ReviewText);

        cmd.ExecuteNonQuery();

        return;
    }
}

int IReviewDAO.SaveReview(Review newReview)
{
    throw new NotImplementedException();
}
