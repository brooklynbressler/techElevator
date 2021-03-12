using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Post> GetAllPosts()
        {
            // Implement this method to pull in all posts from database

            List<Post> listPosts = new List<Post>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT body, created, id, published, name FROM posts;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listPosts.Add(GetPostsFromReader(reader));
                    }
                }
            }
            catch(SqlException)
            {
                throw;
            }

            return listPosts;
        }

        public void Save(Post newPost)
        {
            // Implement this method to save post to database

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO posts(name, body, published, created) VALUES (@name, @body, @published, @created);";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", newPost.Name);
                    cmd.Parameters.AddWithValue("@body", newPost.Body);
                    cmd.Parameters.AddWithValue("@published", newPost.IsPublished);
                    cmd.Parameters.AddWithValue("@created", newPost.Created);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT @@IDENTITY FROM posts", conn);
                    newPost.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (SqlException)
            {

            }
        }
    
        public Post GetPostsFromReader(SqlDataReader reader)
        {
            Post post = new Post();

            post.Body = Convert.ToString(reader["body"]);
            post.Created = Convert.ToDateTime(reader["created"]);
            post.Id = Convert.ToInt32(reader["id"]);
            post.IsPublished = Convert.ToBoolean(reader["published"]);
            post.Name = Convert.ToString(reader["name"]);

            return post;
        }
    
    
    }
}