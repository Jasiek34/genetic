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
            fitPenaltyRadio0 = new RadioButton();
            fitPenaltyRadioPercent = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            minWghtTxtBox = new TextBox();
            minValTxtBox = new TextBox();
            maxWghtTxtBox = new TextBox();
            maxValTxtBox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            wghtIntervalLabel1 = new Label();
            label14 = new Label();
            label13 = new Label();
            initPopZerosTxtBox = new TextBox();
            initPopOnesTxtBox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            noMutatedGenesTxtBox = new TextBox();
            SuspendLayout();
            // 
            // additemBtn
            // 
            additemBtn.Location = new Point(129, 38);
            additemBtn.Name = "additemBtn";
            additemBtn.Size = new Size(110, 23);
            additemBtn.TabIndex = 0;
            additemBtn.Text = "dodaj przedmiot";
            additemBtn.UseVisualStyleBackColor = true;
            additemBtn.Click += additemBtn_Click;
            // 
            // weightTxtBox
            // 
            weightTxtBox.Location = new Point(13, 39);
            weightTxtBox.Name = "weightTxtBox";
            weightTxtBox.Size = new Size(48, 23);
            weightTxtBox.TabIndex = 1;
            // 
            // valueTxtBox
            // 
            valueTxtBox.Location = new Point(67, 39);
            valueTxtBox.Name = "valueTxtBox";
            valueTxtBox.Size = new Size(48, 23);
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
            label2.Location = new Point(67, 16);
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
            addRndItemsBtn.Location = new Point(15, 79);
            addRndItemsBtn.Name = "addRndItemsBtn";
            addRndItemsBtn.Size = new Size(110, 23);
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
            // fitPenaltyRadio0
            // 
            fitPenaltyRadio0.AutoSize = true;
            fitPenaltyRadio0.Checked = true;
            fitPenaltyRadio0.Location = new Point(260, 273);
            fitPenaltyRadio0.Name = "fitPenaltyRadio0";
            fitPenaltyRadio0.Size = new Size(79, 19);
            fitPenaltyRadio0.TabIndex = 34;
            fitPenaltyRadio0.TabStop = true;
            fitPenaltyRadio0.Text = "fitness = 0";
            fitPenaltyRadio0.UseVisualStyleBackColor = true;
            // 
            // fitPenaltyRadioPercent
            // 
            fitPenaltyRadioPercent.AutoSize = true;
            fitPenaltyRadioPercent.Location = new Point(260, 289);
            fitPenaltyRadioPercent.Name = "fitPenaltyRadioPercent";
            fitPenaltyRadioPercent.Size = new Size(177, 19);
            fitPenaltyRadioPercent.TabIndex = 35;
            fitPenaltyRadioPercent.Text = "fitness *= (capacity / weight)";
            fitPenaltyRadioPercent.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 255);
            label8.Name = "label8";
            label8.Size = new Size(160, 15);
            label8.TabIndex = 36;
            label8.Text = "Kara za przepełnienie plecaka";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(260, 343);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 37;
            label9.Text = "Metoda selekcji";
            // 
            // radioButton1
            // 
            radioButton1.AutoCheck = false;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(264, 361);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 38;
            radioButton1.TabStop = true;
            radioButton1.Text = "rangowa";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoCheck = false;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(264, 383);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 39;
            radioButton2.TabStop = true;
            radioButton2.Text = "turniejowa";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoCheck = false;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(264, 404);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 40;
            radioButton3.TabStop = true;
            radioButton3.Text = "ruletkowa";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // minWghtTxtBox
            // 
            minWghtTxtBox.Location = new Point(64, 108);
            minWghtTxtBox.Name = "minWghtTxtBox";
            minWghtTxtBox.Size = new Size(48, 23);
            minWghtTxtBox.TabIndex = 44;
            minWghtTxtBox.Text = "1";
            // 
            // minValTxtBox
            // 
            minValTxtBox.Location = new Point(64, 146);
            minValTxtBox.Name = "minValTxtBox";
            minValTxtBox.Size = new Size(48, 23);
            minValTxtBox.TabIndex = 45;
            minValTxtBox.Text = "0";
            // 
            // maxWghtTxtBox
            // 
            maxWghtTxtBox.Location = new Point(141, 108);
            maxWghtTxtBox.Name = "maxWghtTxtBox";
            maxWghtTxtBox.Size = new Size(48, 23);
            maxWghtTxtBox.TabIndex = 46;
            maxWghtTxtBox.Text = "100";
            // 
            // maxValTxtBox
            // 
            maxValTxtBox.Location = new Point(141, 146);
            maxValTxtBox.Name = "maxValTxtBox";
            maxValTxtBox.Size = new Size(48, 23);
            maxValTxtBox.TabIndex = 47;
            maxValTxtBox.Text = "20";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(123, 108);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 48;
            label11.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(123, 146);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 49;
            label12.Text = "-";
            // 
            // wghtIntervalLabel1
            // 
            wghtIntervalLabel1.AutoSize = true;
            wghtIntervalLabel1.Location = new Point(12, 110);
            wghtIntervalLabel1.Name = "wghtIntervalLabel1";
            wghtIntervalLabel1.Size = new Size(35, 15);
            wghtIntervalLabel1.TabIndex = 50;
            wghtIntervalLabel1.Text = "waga";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 146);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 51;
            label14.Text = "wartość";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(198, 600);
            label13.Name = "label13";
            label13.Size = new Size(125, 15);
            label13.TabIndex = 52;
            label13.Text = "początkowa populacja";
            // 
            // initPopZerosTxtBox
            // 
            initPopZerosTxtBox.Location = new Point(208, 618);
            initPopZerosTxtBox.Name = "initPopZerosTxtBox";
            initPopZerosTxtBox.Size = new Size(28, 23);
            initPopZerosTxtBox.TabIndex = 53;
            initPopZerosTxtBox.Text = "1";
            // 
            // initPopOnesTxtBox
            // 
            initPopOnesTxtBox.Location = new Point(260, 618);
            initPopOnesTxtBox.Name = "initPopOnesTxtBox";
            initPopOnesTxtBox.Size = new Size(29, 23);
            initPopOnesTxtBox.TabIndex = 54;
            initPopOnesTxtBox.Text = "1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(207, 643);
            label15.Name = "label15";
            label15.Size = new Size(22, 15);
            label15.TabIndex = 55;
            label15.Text = "zer";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(260, 644);
            label16.Name = "label16";
            label16.Size = new Size(48, 15);
            label16.TabIndex = 56;
            label16.Text = "jedynek";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(242, 621);
            label17.Name = "label17";
            label17.Size = new Size(12, 15);
            label17.TabIndex = 57;
            label17.Text = "/";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(129, 532);
            label18.Name = "label18";
            label18.Size = new Size(116, 15);
            label18.TabIndex = 58;
            label18.Text = "mutowanych genów";
            // 
            // noMutatedGenesTxtBox
            // 
            noMutatedGenesTxtBox.Location = new Point(128, 550);
            noMutatedGenesTxtBox.Name = "noMutatedGenesTxtBox";
            noMutatedGenesTxtBox.Size = new Size(100, 23);
            noMutatedGenesTxtBox.TabIndex = 59;
            noMutatedGenesTxtBox.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 673);
            Controls.Add(noMutatedGenesTxtBox);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(initPopOnesTxtBox);
            Controls.Add(initPopZerosTxtBox);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(wghtIntervalLabel1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(maxValTxtBox);
            Controls.Add(maxWghtTxtBox);
            Controls.Add(minValTxtBox);
            Controls.Add(minWghtTxtBox);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(fitPenaltyRadioPercent);
            Controls.Add(fitPenaltyRadio0);
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
        private RadioButton fitPenaltyRadio0;
        private RadioButton fitPenaltyRadioPercent;
        private Label label8;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox minWghtTxtBox;
        private TextBox minValTxtBox;
        private TextBox maxWghtTxtBox;
        private TextBox maxValTxtBox;
        private Label label11;
        private Label label12;
        private Label wghtIntervalLabel1;
        private Label label14;
        private Label label13;
        private TextBox initPopZerosTxtBox;
        private TextBox initPopOnesTxtBox;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox noMutatedGenesTxtBox;
    }
}