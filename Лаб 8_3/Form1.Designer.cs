
namespace Лаб_8_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btStart = new System.Windows.Forms.Button();
            this.NumberTrials = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.edProb5 = new System.Windows.Forms.NumericUpDown();
            this.edProb4 = new System.Windows.Forms.NumericUpDown();
            this.edProb3 = new System.Windows.Forms.NumericUpDown();
            this.edProb2 = new System.Windows.Forms.NumericUpDown();
            this.edProb1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIns = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelIns);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.NumberTrials);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edProb5);
            this.panel1.Controls.Add(this.edProb4);
            this.panel1.Controls.Add(this.edProb3);
            this.panel1.Controls.Add(this.edProb2);
            this.panel1.Controls.Add(this.edProb1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 452);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(261, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 449);
            this.panel2.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea2.BorderWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(537, 449);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(59, 378);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(120, 61);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // NumberTrials
            // 
            this.NumberTrials.Location = new System.Drawing.Point(59, 286);
            this.NumberTrials.Name = "NumberTrials";
            this.NumberTrials.Size = new System.Drawing.Size(120, 20);
            this.NumberTrials.TabIndex = 3;
            this.NumberTrials.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numbers of trials";
            // 
            // edProb5
            // 
            this.edProb5.DecimalPlaces = 3;
            this.edProb5.Location = new System.Drawing.Point(105, 195);
            this.edProb5.Name = "edProb5";
            this.edProb5.Size = new System.Drawing.Size(95, 20);
            this.edProb5.TabIndex = 1;
            // 
            // edProb4
            // 
            this.edProb4.DecimalPlaces = 3;
            this.edProb4.Location = new System.Drawing.Point(105, 153);
            this.edProb4.Name = "edProb4";
            this.edProb4.Size = new System.Drawing.Size(95, 20);
            this.edProb4.TabIndex = 1;
            // 
            // edProb3
            // 
            this.edProb3.DecimalPlaces = 3;
            this.edProb3.Location = new System.Drawing.Point(105, 112);
            this.edProb3.Name = "edProb3";
            this.edProb3.Size = new System.Drawing.Size(95, 20);
            this.edProb3.TabIndex = 1;
            // 
            // edProb2
            // 
            this.edProb2.DecimalPlaces = 3;
            this.edProb2.Location = new System.Drawing.Point(105, 66);
            this.edProb2.Name = "edProb2";
            this.edProb2.Size = new System.Drawing.Size(95, 20);
            this.edProb2.TabIndex = 1;
            // 
            // edProb1
            // 
            this.edProb1.DecimalPlaces = 3;
            this.edProb1.Location = new System.Drawing.Point(105, 26);
            this.edProb1.Name = "edProb1";
            this.edProb1.Size = new System.Drawing.Size(95, 20);
            this.edProb1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prob 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prob 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prob 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prob 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // labelIns
            // 
            this.labelIns.AutoSize = true;
            this.labelIns.Location = new System.Drawing.Point(102, 338);
            this.labelIns.Name = "labelIns";
            this.labelIns.Size = new System.Drawing.Size(0, 13);
            this.labelIns.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edProb5;
        private System.Windows.Forms.NumericUpDown edProb4;
        private System.Windows.Forms.NumericUpDown edProb3;
        private System.Windows.Forms.NumericUpDown edProb2;
        private System.Windows.Forms.NumericUpDown edProb1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown NumberTrials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelIns;
    }
}

