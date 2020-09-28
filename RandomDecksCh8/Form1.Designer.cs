namespace RandomDecksCh8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deckList1 = new System.Windows.Forms.ListBox();
            this.deckList2 = new System.Windows.Forms.ListBox();
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.deck1Label = new System.Windows.Forms.Label();
            this.deck2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deckList1
            // 
            this.deckList1.FormattingEnabled = true;
            this.deckList1.Location = new System.Drawing.Point(12, 27);
            this.deckList1.Name = "deckList1";
            this.deckList1.Size = new System.Drawing.Size(120, 225);
            this.deckList1.TabIndex = 0;
            // 
            // deckList2
            // 
            this.deckList2.FormattingEnabled = true;
            this.deckList2.Location = new System.Drawing.Point(246, 27);
            this.deckList2.Name = "deckList2";
            this.deckList2.Size = new System.Drawing.Size(120, 225);
            this.deckList2.TabIndex = 1;
            // 
            // resetDeck1
            // 
            this.resetDeck1.Location = new System.Drawing.Point(12, 258);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(120, 23);
            this.resetDeck1.TabIndex = 2;
            this.resetDeck1.Text = "Reset Deck #1";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(12, 287);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(120, 23);
            this.shuffleDeck1.TabIndex = 3;
            this.shuffleDeck1.Text = "Shuffle Deck #1";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // resetDeck2
            // 
            this.resetDeck2.Location = new System.Drawing.Point(246, 258);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(120, 23);
            this.resetDeck2.TabIndex = 4;
            this.resetDeck2.Text = "Reset Deck #2";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(246, 287);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(120, 23);
            this.shuffleDeck2.TabIndex = 5;
            this.shuffleDeck2.Text = "Shuffle Deck #2";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(138, 101);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(102, 23);
            this.moveToDeck2.TabIndex = 6;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(138, 142);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(102, 23);
            this.moveToDeck1.TabIndex = 7;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // deck1Label
            // 
            this.deck1Label.Location = new System.Drawing.Point(12, 9);
            this.deck1Label.Name = "deck1Label";
            this.deck1Label.Size = new System.Drawing.Size(120, 15);
            this.deck1Label.TabIndex = 8;
            this.deck1Label.Text = "label1";
            // 
            // deck2Label
            // 
            this.deck2Label.Location = new System.Drawing.Point(243, 9);
            this.deck2Label.Name = "deck2Label";
            this.deck2Label.Size = new System.Drawing.Size(123, 15);
            this.deck2Label.TabIndex = 9;
            this.deck2Label.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 326);
            this.Controls.Add(this.deck2Label);
            this.Controls.Add(this.deck1Label);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.deckList2);
            this.Controls.Add(this.deckList1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox deckList1;
        private System.Windows.Forms.ListBox deckList2;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Label deck1Label;
        private System.Windows.Forms.Label deck2Label;
    }
}

