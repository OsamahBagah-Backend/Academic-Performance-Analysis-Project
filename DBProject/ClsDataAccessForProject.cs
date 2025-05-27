using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DBProject
{
    internal class ClsDataAccessForProject
    {
        static public int AddMarksForStudent(int StudentID,int SubjectID,int semesterID,float Grade,string GradeStatus ,int LevelID)
        {
            int _ID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "sp_AddMarksForStudent";

            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new SqlParameter("@StudentID", StudentID));
            Command.Parameters.Add(new SqlParameter("@SubjectID", SubjectID));
            Command.Parameters.Add(new SqlParameter("@SemsterID", semesterID));
            Command.Parameters.Add(new SqlParameter("@Grade", Grade));
            Command.Parameters.Add(new SqlParameter("@GradeStatus", GradeStatus));
            Command.Parameters.Add(new SqlParameter("@LevelID", LevelID));

            try
            {
                Connection.Open();

                int result = Command.ExecuteNonQuery();

                if (result != 0 && int.TryParse(result.ToString(),out int instedID))
                {
                    _ID = instedID;
                }
            }

            catch(Exception ex)
            {
                _ID = -1;
            }

            finally
            {
                Connection.Close();
            }

            return _ID ;
        }

        static public DataTable LoadAllSubjects(string Department,string Level,string Period)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable Table = new DataTable();

            string Query = "sp_GetSubjectsByLevelAndDepartmentAndPeriod";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new SqlParameter("@Department", Department));
            Command.Parameters.Add(new SqlParameter("@Level", Level));
            Command.Parameters.Add(new SqlParameter("@Period", Period));

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Table.Load(Reader);
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return Table;
        }

        static public void GetStudentsNamesForTextBoxe(ref AutoCompleteStringCollection auto)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select FullName from Students";

            SqlCommand Commande = new SqlCommand(Query,Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Commande.ExecuteReader();

                while(Reader.Read())
                {
                    auto.Add(Reader["FullName"].ToString());
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }
        }

        static public int GetStudentID(string StudentName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ID = -1;

            string Query = "select dbo.GetStudentID(@StudentName)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentName", StudentName);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int _ID))
                {
                    ID = _ID;
                }
            }

            catch(Exception ex)
            {
                ID = -1;
            }

            finally { Connection.Close(); }

            return ID;
        }

        static public int GetSubjectsID(string SubjectName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ID = -1;

            string Query = "select dbo.GetSubjectID(@SubjectName)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@SubjectName", SubjectName);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _ID))
                {
                    ID = _ID;
                }
            }

            catch (Exception ex)
            {
                ID = -1;
            }

            finally { Connection.Close(); }

            return ID;
        }

        static public int GetLevelID(string LevelName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ID = -1;

            string Query = "select dbo.GetLevelID(@LevelName)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LevelName", LevelName);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _ID))
                {
                    ID = _ID;
                }
            }

            catch (Exception ex)
            {
                ID = -1;
            }

            finally { Connection.Close(); }

            return ID;
        }

        static public int GetSemesterID(string Name,int year)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ID = -1;

            string Query = "select dbo.GetSemesterID(@Name,@year)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Name",Name);
            Command.Parameters.AddWithValue("@year",year);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _ID))
                {
                    ID = _ID;
                }
            }

            catch (Exception ex)
            {
                ID = -1;
            }

            finally { Connection.Close(); }

            return ID;
        }

        static public bool CheckFromThisRecordIfAlreadtEntring(int StudentID , int SubjectID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            bool IsFound = false;

            string Query = "select dbo.CheckFromGradeInfoIfIsAlreadyEntring(@StudentID ,@SubjectID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);
            Command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool Found))
                {
                    IsFound = Found;
                }
            }

            catch (Exception ex)
            {
                IsFound= false;
            }

            finally { Connection.Close(); }

            return IsFound;
        }

        static public bool CheckFromStudentNameIfThereOrNot(string StudentName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            bool IsFound = false;

            string Query = "select dbo.CheckIfStudentNameIsThereOrNot (@StudentName)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentName", StudentName);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool Found))
                {
                    IsFound = Found;
                }
            }

            catch (Exception ex)
            {
                IsFound = false;
            }

            finally { Connection.Close(); }

            return IsFound;
        }

        static public DataTable GetDepartmentsForStudents(int StudentID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from dbo.GetStudentDepartments(@StudentID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public DataTable GetSemestersForStudents(int StudentID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from dbo.GetStudentSemesters(@StudentID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }

            catch (Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public DataTable GetLevelsForStudents(int StudentID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from dbo.GetStudentLevels(@StudentID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }

            catch (Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public void StudentStatsics(string StudetnName , string SemesterName , 
            int SemesterYear ,string LevelName , string DepartmentName,ref int HisOrder,ref int HisPercentage, ref DataTable Subjectsdt)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "sp_StudentStatistics";

            SqlCommand Command = new SqlCommand(Query , Connection);

            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@StudentName", StudetnName);
            Command.Parameters.AddWithValue("@SemesterName", SemesterName);
            Command.Parameters.AddWithValue("@SemesterYear", SemesterYear);
            Command.Parameters.AddWithValue("@LevelName", LevelName);
            Command.Parameters.AddWithValue("@Department", DepartmentName);


            SqlParameter output1 = new SqlParameter("@HisOrder", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output1);

            SqlParameter output2 = new SqlParameter("@HisPercent", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output2);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                HisOrder = Convert.ToInt32(output1.Value);
                HisPercentage = Convert.ToInt32(output2.Value);
                Subjectsdt = dt;
                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }
        }

        static public void TheBatchStatistics(string SemesterName,int SemesterYear,
            string LevelName, string Department , ref int FinalOutcom,ref int HonorPercentage,
            ref int StudentMaleCount , ref int StudentFamaleCount,ref DataTable Successdt,
            ref DataTable Failddt,ref DataTable Top10Student)

        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "sp_TheBatchStatistics";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.CommandType = CommandType.StoredProcedure;

            
            Command.Parameters.AddWithValue("@SemesterName", SemesterName);
            Command.Parameters.AddWithValue("@SemesterYear", SemesterYear);
            Command.Parameters.AddWithValue("@LevelName", LevelName);
            Command.Parameters.AddWithValue("@Department", Department);

            SqlParameter output1 = new SqlParameter("@TheFinalOutCome", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output1);

            SqlParameter output2 = new SqlParameter("@HonorPercentage", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output2);

            SqlParameter output3 = new SqlParameter("@StudentMaleCount", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output3);

            SqlParameter output4 = new SqlParameter("@StudentFamaleCount", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output4);


            try
            {
                Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                DataSet ds = new DataSet();
                adapter.Fill(ds); // هذا لحاله يجيب كل الجداول بدون NextResult

                if (ds.Tables.Count > 0)
                    Successdt = ds.Tables[0];
                if (ds.Tables.Count > 1)
                    Failddt = ds.Tables[1];
                if (ds.Tables.Count > 2)
                    Top10Student = ds.Tables[2];

                // قراءة باراميترات الإخراج
                FinalOutcom = output1.Value != DBNull.Value ? Convert.ToInt32(output1.Value) : 0;
                HonorPercentage = output2.Value != DBNull.Value ? Convert.ToInt32(output2.Value) : 0;
                StudentMaleCount = output3.Value != DBNull.Value ? Convert.ToInt32(output3.Value) : 0;
                StudentFamaleCount = output4.Value != DBNull.Value ? Convert.ToInt32(output4.Value) : 0;

                
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }
        }


        static public bool CheckFromBatchSataisics(string SemesterName,int SemesterYear , string LevelName,string Department)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            bool IsFound = false;

            string Query = "select dbo.CheckFromMarksForBatchStatistics(@SemesterName ,@Semesteryear ,@LevelName ,@Department)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@SemesterName", SemesterName);
            Command.Parameters.AddWithValue("@Semesteryear", SemesterYear);
            Command.Parameters.AddWithValue("@LevelName", LevelName);
            Command.Parameters.AddWithValue("@Department", Department);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool Found))
                {
                    IsFound = Found;
                }
            }

            catch (Exception ex)
            {
                IsFound = false;
            }

            finally { Connection.Close(); }

            return IsFound;
        }


        static public void TheBatchStatisticsByGender(string SemesterName, int SemesterYear,
            string LevelName, string Department, ref int FinalOutcomMale, ref int FinalOutcomFaMale, ref int HonorPercentageMale, ref int HonorPercentageFaMale,
            ref int StudentMaleCount, ref int StudentFamaleCount, ref DataTable SuccessdtMale,
            ref DataTable SuccessdtFamale)

        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "sp_TheBatchStatisticsByGender";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.StoredProcedure;


            Command.Parameters.AddWithValue("@SemesterName", SemesterName);
            Command.Parameters.AddWithValue("@SemesterYear", SemesterYear);
            Command.Parameters.AddWithValue("@LevelName", LevelName);
            Command.Parameters.AddWithValue("@Department", Department);

            SqlParameter output1 = new SqlParameter("@TheFinalOutComeMale", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output1);

            SqlParameter output2 = new SqlParameter("@TheFinalOutComeFaMale", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output2);

            SqlParameter output3 = new SqlParameter("@HonorPercentageMale", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output3);

            SqlParameter output4 = new SqlParameter("@HonorPercentageFaMale", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output4);

            SqlParameter output5 = new SqlParameter("@StudentMaleCount", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output5);

            SqlParameter output6 = new SqlParameter("@StudentFamaleCount", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(output6);

            try
            {
                Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                DataSet ds = new DataSet();
                adapter.Fill(ds); // هذا لحاله يجيب كل الجداول بدون NextResult

                if (ds.Tables.Count > 0)
                    SuccessdtMale = ds.Tables[0];
                if (ds.Tables.Count > 1)
                    SuccessdtFamale = ds.Tables[1];
                

                // قراءة باراميترات الإخراج
                FinalOutcomMale = output1.Value != DBNull.Value ? Convert.ToInt32(output1.Value) : 0;
                FinalOutcomFaMale = output2.Value != DBNull.Value ? Convert.ToInt32(output2.Value) : 0;
                HonorPercentageMale = output3.Value != DBNull.Value ? Convert.ToInt32(output3.Value) : 0;
                HonorPercentageFaMale = output4.Value != DBNull.Value ? Convert.ToInt32(output4.Value) : 0;
                StudentMaleCount = output5.Value != DBNull.Value ? Convert.ToInt32(output5.Value) : 0;
                StudentFamaleCount = output6.Value != DBNull.Value ? Convert.ToInt32(output6.Value) : 0;

            }

            catch (Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }
        }

        static public DataTable GetFinalPaymentStatement(string SemesterName,
            int SemesterYear, string LevelName, string DepartmentName)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "sp_GetFinalPaymentStatement";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@SemesterName", SemesterName);
            Command.Parameters.AddWithValue("@SemesterYear", SemesterYear);
            Command.Parameters.AddWithValue("@LevelName", LevelName);
            Command.Parameters.AddWithValue("@Department", DepartmentName);



            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                
                Reader.Close();
            }

            catch (Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }
    }
}
