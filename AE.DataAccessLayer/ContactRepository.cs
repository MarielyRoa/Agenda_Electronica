using AE.Domain;
using AE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE.DataAccessLayer
{
    public class ContactRepository : IContactRepository
    {
        public int Insert(Contact contact)
        {
            using (SqlConnection conn = ConnectionBD.conectar())

            using (SqlCommand cmd = new SqlCommand("sp_Contact_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", contact.Name);
                cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                cmd.Parameters.AddWithValue("@Birthday", (object)contact.Birthday ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)contact.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Mobile", (object)contact.Mobile ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", (object)contact.PhoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", (int)contact.Gender);
                cmd.Parameters.AddWithValue("@CivilStatus", (int)contact.CivilStatusType);
                cmd.Parameters.AddWithValue("@Email", (object)contact.Email ?? DBNull.Value);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public bool Update(Contact contact)
        {
            using (SqlConnection conn = ConnectionBD.conectar())
            using (SqlCommand cmd = new SqlCommand("sp_Contact_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", contact.Id);
                cmd.Parameters.AddWithValue("@Name", contact.Name);
                cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                cmd.Parameters.AddWithValue("@Birthday", (object)contact.Birthday ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)contact.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Mobile", (object)contact.Mobile ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", (object)contact.PhoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", (int)contact.Gender);
                cmd.Parameters.AddWithValue("@CivilStatus", (int)contact.CivilStatusType);
                cmd.Parameters.AddWithValue("@Email", (object)contact.Email ?? DBNull.Value);

                conn.Open();
                int affected = Convert.ToInt32(cmd.ExecuteScalar()); // SP devuelve AffectedRows
                return affected > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = ConnectionBD.conectar())
            using (SqlCommand cmd = new SqlCommand("sp_Contact_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                int affected = Convert.ToInt32(cmd.ExecuteScalar()); // SP devuelve AffectedRows
                return affected > 0;
            }
        }

        public Contact GetById(int id)
        {
            using (SqlConnection conn = ConnectionBD.conectar())
            using (SqlCommand cmd = new SqlCommand("sp_Contact_GetById", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        return MapContact(dr);
                }
            }

            return null;
        }

        public List<Contact> GetAll()
        {
            List<Contact> list = new List<Contact>();

            using (SqlConnection conn = ConnectionBD.conectar())
            using (SqlCommand cmd = new SqlCommand("sp_Contact_GetAll", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        list.Add(MapContact(dr));
                }
            }

            return list;
        }

        public List<Contact> Search(int? id, string lastName)
        {
            List<Contact> list = new List<Contact>();

            using (SqlConnection conn = ConnectionBD.conectar())
            using (SqlCommand cmd = new SqlCommand("sp_Contact_Search", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", (object)id ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(lastName) ? (object)DBNull.Value : lastName);

                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        list.Add(MapContact(dr));
                }
            }

            return list;
        }

        private Contact MapContact(SqlDataReader dr)
        {
            return new Contact
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                LastName = dr["LastName"].ToString(),
                Birthday = dr["Birthday"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["Birthday"]),
                Address = dr["Address"] == DBNull.Value ? null : dr["Address"].ToString(),
                Mobile = dr["Mobile"] == DBNull.Value ? null : dr["Mobile"].ToString(),
                PhoneNumber = dr["PhoneNumber"] == DBNull.Value ? null : dr["PhoneNumber"].ToString(),
                Gender = (GenderMF)Convert.ToInt32(dr["Gender"]),
                CivilStatusType = (CivilStatus)Convert.ToInt32(dr["CivilStatus"]),
                Email = dr["Email"] == DBNull.Value ? null : dr["Email"].ToString()
            };
        }
    }
}
