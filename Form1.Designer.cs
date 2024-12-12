namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            additemBtn = new Button();
            weightTxtBox = new TextBox();
            valueTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            itemsListView = new ListView();
            resultLabel = new Label();
            showOptResBtn = new Button();
            optReslabel = new Label();
            clearBtn = new Button();
            geneticBtn = new Button();
            populationTxtBox = new TextBox();
            label3 = new Label();
            capacityTxtBox = new TextBox();
            label4 = new Label();
            addRndItemsBtn = new Button();
            itemsNoLabel = new Label();
            generationsNoTxtBox = new TextBox();
            generacje = new Label();
            label5 = new Label();
            selectionPressureTxtBox = new TextBox();
            noGenLabel = new Label();
            crossoverRateLabel = new Label();
            crossoverRateTxtBox = new TextBox();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            mutationRateTxtBox = new TextBox();
            label6 = new Label();
            elitCB = new CheckBox();
            elitismTxtBox = new TextBox();
            label7 = new Label();
            weightLabel = new Label();
            SuspendLayout();
            // 
            // additemBtn
            // 
            additemBtn.Location = new Point(244, 40);
            additemBtn.Name = "additemBtn";
            additemBtn.Size = new Size(110, 23);
            additemBtn.TabIndex = 0;
            additemBtn.Text = "dodaj przedmiot";
            additemBtn.UseVisualStyleBackColor = true;
            additemBtn.Click += additemBtn_Click;
            // 
            // weightTxtBox
            // 
            weightTxtBox.Location = new Point(12, 39);
            weightTxtBox.Name = "weightTxtBox";
            weightTxtBox.Size = new Size(100, 23);
            weightTxtBox.TabIndex = 1;
            // 
            // valueTxtBox
            // 
            valueTxtBox.Location = new Point(128, 39);
            valueTxtBox.Name = "valueTxtBox";
            valueTxtBox.Size = new Size(100, 23);
            valueTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "waga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 16);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "wartość";
            // 
            // itemsListView
            // 
            itemsListView.Location = new Point(13, 188);
            itemsListView.Margin = new Padding(1);
            itemsListView.Name = "itemsListView";
            itemsListView.Size = new Size(100, 427);
            itemsListView.TabIndex = 6;
            itemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(384, 503);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(131, 15);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "Znalezione rozwiązanie:";
            // 
            // showOptResBtn
            // 
            showOptResBtn.Location = new Point(664, 468);
            showOptResBtn.Name = "showOptResBtn";
            showOptResBtn.Size = new Size(110, 23);
            showOptResBtn.TabIndex = 8;
            showOptResBtn.Text = "Pokaż optymalne";
            showOptResBtn.UseVisualStyleBackColor = true;
            showOptResBtn.Click += showOptResBtn_Click;
            // 
            // optReslabel
            // 
            optReslabel.AutoSize = true;
            optReslabel.Location = new Point(814, 471);
            optReslabel.Name = "optReslabel";
            optReslabel.Size = new Size(0, 15);
            optReslabel.TabIndex = 9;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(1066, 40);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "reset";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // geneticBtn
            // 
            geneticBtn.DialogResult = DialogResult.No;
            geneticBtn.Location = new Point(384, 468);
            geneticBtn.Name = "geneticBtn";
            geneticBtn.Size = new Size(119, 23);
            geneticBtn.TabIndex = 11;
            geneticBtn.Text = "Znajdź rozwiązanie";
            geneticBtn.UseVisualStyleBackColor = true;
            geneticBtn.Click += geneticBtn_Click;
            // 
            // populationTxtBox
            // 
            populationTxtBox.Location = new Point(128, 272);
            populationTxtBox.Name = "populationTxtBox";
            populationTxtBox.Size = new Size(100, 23);
            populationTxtBox.TabIndex = 12;
            populationTxtBox.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 254);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 13;
            label3.Text = "populacja";
            // 
            // capacityTxtBox
            // 
            capacityTxtBox.Location = new Point(128, 213);
            capacityTxtBox.Name = "capacityTxtBox";
            capacityTxtBox.Size = new Size(100, 23);
            capacityTxtBox.TabIndex = 14;
            capacityTxtBox.Text = "60";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 189);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 15;
            label4.Text = "pojemność";
            // 
            // addRndItemsBtn
            // 
            addRndItemsBtn.DialogResult = DialogResult.OK;
            addRndItemsBtn.Location = new Point(13, 84);
            addRndItemsBtn.Name = "addRndItemsBtn";
            addRndItemsBtn.Size = new Size(100, 23);
            addRndItemsBtn.TabIndex = 17;
            addRndItemsBtn.Text = "Dodaj losowe";
            addRndItemsBtn.UseVisualStyleBackColor = true;
            addRndItemsBtn.Click += addRndItemsBtn_Click;
            // 
            // itemsNoLabel
            // 
            itemsNoLabel.AutoSize = true;
            itemsNoLabel.Location = new Point(15, 628);
            itemsNoLabel.Name = "itemsNoLabel";
            itemsNoLabel.Size = new Size(80, 15);
            itemsNoLabel.TabIndex = 18;
            itemsNoLabel.Text = "przedmiotów:";
            itemsNoLabel.Visible = false;
            // 
            // generationsNoTxtBox
            // 
            generationsNoTxtBox.Location = new Point(129, 325);
            generationsNoTxtBox.Name = "generationsNoTxtBox";
            generationsNoTxtBox.Size = new Size(100, 23);
            generationsNoTxtBox.TabIndex = 19;
            generationsNoTxtBox.Text = "10";
            // 
            // generacje
            // 
            generacje.AutoSize = true;
            generacje.Location = new Point(128, 307);
            generacje.Name = "generacje";
            generacje.Size = new Size(58, 15);
            generacje.TabIndex = 20;
            generacje.Text = "generacje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 361);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 21;
            label5.Text = "Presja selekcji";
            // 
            // selectionPressureTxtBox
            // 
            selectionPressureTxtBox.Location = new Point(129, 379);
            selectionPressureTxtBox.Name = "selectionPressureTxtBox";
            selectionPressureTxtBox.Size = new Size(100, 23);
            selectionPressureTxtBox.TabIndex = 22;
            selectionPressureTxtBox.Text = "1,2";
            // 
            // noGenLabel
            // 
            noGenLabel.AutoSize = true;
            noGenLabel.Location = new Point(384, 558);
            noGenLabel.Name = "noGenLabel";
            noGenLabel.Size = new Size(94, 15);
            noGenLabel.TabIndex = 23;
            noGenLabel.Text = "Liczba generacji:";
            // 
            // crossoverRateLabel
            // 
            crossoverRateLabel.AutoSize = true;
            crossoverRateLabel.Location = new Point(129, 425);
            crossoverRateLabel.Name = "crossoverRateLabel";
            crossoverRateLabel.Size = new Size(105, 15);
            crossoverRateLabel.TabIndex = 25;
            crossoverRateLabel.Text = "krzyżowanie (0-10)";
            // 
            // crossoverRateTxtBox
            // 
            crossoverRateTxtBox.Location = new Point(129, 443);
            crossoverRateTxtBox.Name = "crossoverRateTxtBox";
            crossoverRateTxtBox.Size = new Size(100, 23);
            crossoverRateTxtBox.TabIndex = 26;
            crossoverRateTxtBox.Text = "8";
            // 
            // plotView1
            // 
            plotView1.Location = new Point(441, 16);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(597, 386);
            plotView1.TabIndex = 27;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // mutationRateTxtBox
            // 
            mutationRateTxtBox.Location = new Point(128, 495);
            mutationRateTxtBox.Name = "mutationRateTxtBox";
            mutationRateTxtBox.Size = new Size(100, 23);
            mutationRateTxtBox.TabIndex = 28;
            mutationRateTxtBox.Text = "30";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 477);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 29;
            label6.Text = "mutacja (0-100)";
            // 
            // elitCB
            // 
            elitCB.AutoSize = true;
            elitCB.Location = new Point(254, 188);
            elitCB.Name = "elitCB";
            elitCB.Size = new Size(104, 19);
            elitCB.TabIndex = 30;
            elitCB.Text = "Elityzm (0-100)";
            elitCB.UseVisualStyleBackColor = true;
            // 
            // elitismTxtBox
            // 
            elitismTxtBox.Location = new Point(254, 213);
            elitismTxtBox.Name = "elitismTxtBox";
            elitismTxtBox.Size = new Size(100, 23);
            elitismTxtBox.TabIndex = 31;
            elitismTxtBox.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 172);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 32;
            label7.Text = "waga   wartość";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(384, 532);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(40, 15);
            weightLabel.TabIndex = 33;
            weightLabel.Text = "Waga:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 673);
            Controls.Add(weightLabel);
            Controls.Add(label7);
            Controls.Add(elitismTxtBox);
            Controls.Add(elitCB);
            Controls.Add(label6);
            Controls.Add(mutationRateTxtBox);
            Controls.Add(plotView1);
            Controls.Add(crossoverRateTxtBox);
            Controls.Add(crossoverRateLabel);
            Controls.Add(noGenLabel);
            Controls.Add(selectionPressureTxtBox);
            Controls.Add(label5);
            Controls.Add(generacje);
            Controls.Add(generationsNoTxtBox);
            Controls.Add(itemsNoLabel);
            Controls.Add(addRndItemsBtn);
            Controls.Add(label4);
            Controls.Add(capacityTxtBox);
            Controls.Add(label3);
            Controls.Add(populationTxtBox);
            Controls.Add(geneticBtn);
            Controls.Add(clearBtn);
            Controls.Add(optReslabel);
            Controls.Add(showOptResBtn);
            Controls.Add(resultLabel);
            Controls.Add(itemsListView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valueTxtBox);
            Controls.Add(weightTxtBox);
            Controls.Add(additemBtn);
            Name = "Form1";
            Text = "Knapsack Problem (GA)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button additemBtn;
        private TextBox weightTxtBox;
        private TextBox valueTxtBox;
        private Label label1;
        private Label label2;
        private ListView itemsListView;
        private Label resultLabel;
        private Button showOptResBtn;
        private Label optReslabel;
        private Button clearBtn;
        private Button geneticBtn;
        private TextBox populationTxtBox;
        private Label label3;
        private TextBox capacityTxtBox;
        private Label label4;
        private Button addRndItemsBtn;
        private Label itemsNoLabel;
        private TextBox generationsNoTxtBox;
        private Label generacje;
        private Label label5;
        private TextBox selectionPressureTxtBox;
        private Label noGenLabel;
        private Label crossoverRateLabel;
        private TextBox crossoverRateTxtBox;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private TextBox mutationRateTxtBox;
        private Label label6;
        private CheckBox elitCB;
        private TextBox elitismTxtBox;
        private Label label7;
        private Label weightLabel;
    }
}