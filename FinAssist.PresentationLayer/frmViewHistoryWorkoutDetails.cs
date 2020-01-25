﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FinAssist.BaseLib;
using FinAssist.Controllers;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewHistoryWorkoutDetails : Form, IShowHistoryWorkoutDetails
    {
        public frmViewHistoryWorkoutDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        public void ShowHistoryWorkoutDetails(HistoryWorkout historyWorkout)
        {
            txtHistoryWorkoutDetails.Text = historyWorkout.ToString();
            //var photoName = exercise.PhotoAbbv;
            //switch (photoName)
            //{
            //    case "bench_press":
            //        pictureBoxExercise.Image = Properties.Resources.bench_press;
            //        break;
            //    case "military_press":
            //        pictureBoxExercise.Image = Properties.Resources.military_press;
            //        break;
            //    case "deadlift":
            //        pictureBoxExercise.Image = Properties.Resources.deadlift;
            //        break;
            //    case "squat":
            //        pictureBoxExercise.Image = Properties.Resources.squat;
            //        break;
            //}
            this.Text = historyWorkout.WorkoutName;

            this.Show();
        }

        private void frmViewHistoryWorkoutDetails_Load(object sender, EventArgs e)
        {

        }

        private void labelhistoryWorkoutDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
