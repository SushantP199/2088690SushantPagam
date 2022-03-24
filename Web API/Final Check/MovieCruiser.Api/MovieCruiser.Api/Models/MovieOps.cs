using System.Data;
using System.Data.SqlClient;

namespace MovieCruiser.Api.Models
{
    public class MovieOps
    {
        public static string sqlConnString = "Server=(localdb)\\mssqllocaldb;Database=Movie;Trusted_Connection=True;MultipleActiveResultSets=true;";
        private static SqlDataReader sqlDataReader;

        public static IEnumerable<Movie> GetMoviesList(string conn)
        {
            List<Movie> moviesList = new List<Movie>();

            SqlConnection sqlConnection = new SqlConnection(conn);

            string query = "SELECT * FROM Movie";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();

                var reader = sqlCommand.ExecuteReader();

                Movie movieItem = null;
                while (reader.Read())
                {
                    movieItem = new Movie();
                    movieItem.Id = reader.GetInt32(0);
                    movieItem.Title = reader.GetString(1);
                    movieItem.BoxOffice = reader.GetString(2);
                    movieItem.Active = reader.GetBoolean(3);
                    movieItem.DateOfLaunch = reader.GetDateTime(4);
                    movieItem.HasTeaser = reader.GetBoolean(5);
                    movieItem.GenreId = reader.GetInt32(6);
                    movieItem.GenreType = reader.GetString(7);

                    moviesList.Add(movieItem);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return moviesList;
        }

        public static bool Update(int id, Movie movie)
        {
            var list = new List<string> {"Comedy", "Science Fiction", "Documentary", "Romance",};

            using (SqlConnection sqlConnection = new SqlConnection(sqlConnString))
            {

                string query = $"UPDATE Movie SET Id={id}, Title='{movie.Title}', BoxOffice='{movie.BoxOffice}', Active='{movie.Active}', DateOfLaunch='{movie.DateOfLaunch}', HasTeaser='{movie.HasTeaser}', GenreId={movie.GenreId}, GenreType='{movie.GenreType}' WHERE id={id}";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            }
        }

        public static void Insert(User user)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnString);

            string query = $"INSERT INTO UserDetails (Id,UserName,FirstName,LastName,Password,ConfirmPassword) VALUES ({user.Id}, '{user.UserName}', '{user.FirstName}', '{user.LastName}', '{user.Password}', '{user.ConfirmPassword}')";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static List<User> UserList()
        {
            List<User> users = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(sqlConnString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM User";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        users.Add(new User
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            UserName = sqlDataReader["UserName"].ToString(),
                            FirstName = sqlDataReader["FirstName"].ToString(),
                            LastName = sqlDataReader["LastName"].ToString(),
                            Password = sqlDataReader["PasswosqlDataReader"].ToString(),
                            ConfirmPassword = sqlDataReader["ConfirmPasswosqlDataReader"].ToString()

                        });
                    }

                    sqlConnection.Close();
                }
            }
            return users;
        }

        public static void InsertIntoFavorites(List<Favorite> favorite)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnString);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO Favorites(Id,MovieListId,UserId) Values (@Id,@MovieListId,@UserId)";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            foreach (var i in favorite)
            {
                sqlCommand.Parameters.AddWithValue("@Id", i.Id);
                sqlCommand.Parameters.AddWithValue("@MovieListId", i.MovieListId);
                sqlCommand.Parameters.AddWithValue("@UserId", i.UserId);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
            }

            sqlConnection.Close();
        }

        public static List<Movie> FavoriteList(int userId, ref int rowCount)
        {

            List<Movie> items = new List<Movie>();
            List<int> list = new List<int>();

            using (SqlConnection sqlConnection = new SqlConnection(sqlConnString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = $"SELECT Movie FROM Favorite WHERE UserId = {userId}";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        list.Add(Convert.ToInt32(sqlDataReader["MovieListId"]));
                    }
                    sqlDataReader.Close();

                    foreach (var i in list)
                    {
                        sqlCommand.CommandText = $"SELECT * FROM Movie WHERE Id = {i}";

                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            items.Add(new Movie
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Title = dataReader["Title"].ToString(),
                                BoxOffice = dataReader["BoxOffice"].ToString(),
                                Active = Convert.ToBoolean(dataReader["Active"]),
                                DateOfLaunch = Convert.ToDateTime(dataReader["DateOfLaunch"]),
                                HasTeaser = Convert.ToBoolean(dataReader["HasTeaser"]),
                                GenreId = Convert.ToInt32(dataReader["GenreId"]),
                                GenreType = dataReader["GenreType"].ToString()
                            });
                            rowCount += Convert.ToInt32(dataReader["Id"]);

                        }
                        sqlCommand.Parameters.Clear();
                        dataReader.Close();
                    }
                    sqlConnection.Close();
                }
            }
            return items;
        }

        public static string Delete(int favId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnString);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $"DELETE FROM Favorite WHERE Id = {favId}";
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();
            int i = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (i >= 1)
                return "Record vanished";
            else
                return "No record found";
        }
    }
}
