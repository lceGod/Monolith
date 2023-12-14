﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;

namespace MonolithMainForm
{
    class DataBase
    {
        static readonly MySqlConnection connection = new(
            "server=localhost;" +
            "port=3306;" +
            "user=root;" +
            "password=root;" +
            "database=monolith");

        public void OpenConection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConection()
        {
            return connection;
        }

        #region
        public List<Placement> GetPlacements()
        {
            var placements = new List<Placement>();

            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM placements", GetConection());

            OpenConection();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            CloseConection();

            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                var id = (int)(uint)cells[0];
                var name = (string)cells[1];
                var password = (string)cells[2];
                var itIsStorage = (bool)cells[3];
                var placement = new Placement(name, itIsStorage);
                placement.Materials = GetMaterials(name);

                placements.Add(placement);
            }


            return placements;
        }

        public Placement GetPlacement(string name)
        {

            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM placements Where name = @name", GetConection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

            OpenConection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            CloseConection();

            Placement placement = null;
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                var id = (int)(uint)cells[0];
                var password = (string)cells[2];
                var itIsStorage = (bool)cells[3];
                placement = new Placement(name, itIsStorage);
                placement.Materials = GetMaterials(name);
            }

            return placement;
        }
        public List<Material> GetMaterials(string placementName)
        {
            var materials = new List<Material>();

            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM materials WHERE placementName = @placementName", GetConection());
            command.Parameters.Add("@placementName", MySqlDbType.VarChar).Value = placementName;

            OpenConection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                var id = (int)(uint)cells[0];
                var name = (string)cells[2];
                var count = (double)cells[3];
                var unit = (string)cells[4];
                var limit = (double)cells[5];
                materials.Add(new Material(name, count, unit, limit));
            }
            CloseConection();


            return materials;
        }
        #endregion 

        public void AddMaterial(Material material, string placementName)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `materials` (`placementName`, `name`, `count`, `unit`, `countLimit`) VALUES (@placeName, @name, @count, @unit, @Limit)", GetConection());
            command.Parameters.Add("@placeName", MySqlDbType.VarChar).Value = placementName;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = material.Name;
            command.Parameters.Add("@count", MySqlDbType.Double).Value = material.Count;
            command.Parameters.Add("@unit", MySqlDbType.VarChar).Value = material.Unit;
            command.Parameters.Add("@limit", MySqlDbType.Double).Value = material.Limit;
            OpenConection();

            if (command.ExecuteNonQuery() != 1)
                throw new Exception("PZDC");

            CloseConection();
        }

        public void DeleteMaterial(int id)
        {
            var command = new MySqlCommand("DELETE FROM `materials` WHERE `materials`.`id` = @id", GetConection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            OpenConection();
            command.ExecuteNonQuery();
            CloseConection();
        }

        public void UpdateMaterailList(string placementName, List<Material> materials)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT id FROM materials WHERE placementName = @placementName", GetConection());
            command.Parameters.Add("@placementName", MySqlDbType.VarChar).Value = placementName;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                var id = (int)(uint)cells[0];
                DeleteMaterial(id);
            }

            foreach (var material in materials)
            {
                AddMaterial(material, placementName);
            }
        }
    }
}
