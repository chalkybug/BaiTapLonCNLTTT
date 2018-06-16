using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;


namespace MapWeb.Models
{
    public class Notification : System.Web.UI.Page
    {
        public static string m_connect = @"Data Source=.\sqlexpress;Initial Catalog=qlPCCC;Integrated Security=true";
        
        public static int cout;

        private Notification() { }

        private static volatile Notification instance;

        static object key = new object();

        public static Notification Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new Notification();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public void inti()
        {
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
      
            // call
            StartListening();
        }


        public void StartListening()
        {

            using (var con = new SqlConnection(m_connect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id FROM dbo.notice", con);
                cmd.Notification = null;

                SqlDependency de = new SqlDependency(cmd);
                de.OnChange += de_OnChange;

                // cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.ExecuteReader();

            }


        }


        private void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            // acction something
         
            
            playSimpleSound();
            StartListening();
        }

      
        private void playSimpleSound()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString(); // folder name
            SoundPlayer simpleSound = new SoundPlayer(path+"music.wav");
            simpleSound.Play();
        }

    }
}