using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_B10523025_陳冠廷
{
    public partial class Form1 : Form
    {
        int point_num = 0;
        Dictionary<int,Point> pointlist = new Dictionary<int, Point>();
        List<Line> linelist = new List<Line>();
        int circle_quantity = 0;
        Boolean cycle_state=false;
        System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
        System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Wheat);
        System.Drawing.SolidBrush drawstring = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        System.Drawing.Pen drawpen = new System.Drawing.Pen(System.Drawing.Color.Wheat,3);
        System.Drawing.Pen drawtree = new System.Drawing.Pen(System.Drawing.Color.Red, 5);
        System.Drawing.SolidBrush drawtreestring = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(x_position.Text.Equals("")) && !(y_position.Text.Equals("")))
            {
                point_num++;
                Graphics graphics = this.CreateGraphics();
                Point point = new Point(Int32.Parse(x_position.Text), Int32.Parse(y_position.Text), point_num);
                pointlist.Add(point_num, point);
                point.drawPoint(graphics, drawBrush, drawFont, drawstring);
            }
            else
                MessageBox.Show("please input value!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.SkyBlue);
            point_num = 0;
            pointlist.Clear();
        }

        private void draw_line_bottom_Click(object sender, EventArgs e)
        {
            
            Graphics graphics = this.CreateGraphics();
            if (pointlist.Count == 0)
                MessageBox.Show("There is no point in the graph!!");
            else
            {
                if (circle1_text.Text == "" || circle2_text.Text == "" || weight_text.Text == "")
                {
                    MessageBox.Show("Please input point or weight!!");
                }
                else if (!(pointlist.ContainsKey(Int32.Parse(circle1_text.Text)) && pointlist.ContainsKey(Int32.Parse(circle2_text.Text))))
                {
                    MessageBox.Show("Please input correct point!!");
                }
                else
                {
                    Point p1 = pointlist[Int32.Parse(circle1_text.Text)];
                    Point p2 = pointlist[Int32.Parse(circle2_text.Text)];
                    Line line = new Line(p1, p2, Int32.Parse(weight_text.Text));
                    linelist.Add(line);
                   
                    line.drawline(graphics, drawpen, drawFont, drawstring);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        public Line getminline(List<Line> list)
        {
            Line templine = list.ElementAt(0);
            foreach (Line line in linelist)
            {
                if (templine.GetWeight() > line.GetWeight())
                {
                    templine = line;
                }
            }
            return templine;
        }
        public Boolean cycle(Line line)
        {
            Point p1 = line.GetPoint1();
            Point p2 = line.GetPoint2();
            List<Point> p1list = p1.gettree().getreelist();
            List<Point> p2list = p2.gettree().getreelist();
            if (line.decisionunion(p1.gettree(), p2.gettree()) == false)
            {
                p1list = p1list.Union(p2list).ToList();
                p1.gettree().setlist(p1list);
                p2.gettree().setlist(p1list);

                foreach (Point p in p1list)
                {
                    p.gettree().setlist(p1list); ;
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button1_Click_3(object sender, EventArgs e)
        {            
            if (pointlist.Count() == 0)
            {
                MessageBox.Show("There is no point in the graph!!");
            }
            else
            {
                List<Line> templist = new List<Line>();
                Graphics graphics = this.CreateGraphics();
                Line minline = getminline(linelist);
                while (templist.Count() < pointlist.Count() && (pointlist.Count() > 0))
                {
                    if (templist.Count() > 0)
                    {
                        minline = getminline(linelist);
                        templist.Add(minline);
                        linelist.Remove(minline);
                        if (cycle(minline))
                        {
                            templist.Remove(minline);
                        }
                        else
                        {
                            minline.drawline(graphics, drawtree, drawFont, drawtreestring);
                        }
                    }
                    else
                    {
                        templist.Add(minline);
                        minline.drawline(graphics, drawtree, drawFont, drawtreestring);
                    }
                }   
            }
            
         }
     }
}
public class Point
{
    private int x, y,number;
    Tree tree;
    public Point(int x, int y,int number)
    {
        this.x = x;
        this.y = y;
        this.number = number;
        this.tree = new Tree(this);
    }
    public int getx()
    {
        return x;
    }
    public int gety()
    {
        return y;
    }
    public int getnumber()
    {
        return number;
    }
    public Tree gettree()
    {
        return tree;
    }
    public void settree(Tree tree)
    {
        this.tree = tree;
    }
    public void drawPoint(Graphics graphics,SolidBrush drawBrush, Font drawFont, SolidBrush drawstring)
    {
        graphics.FillRectangle(drawBrush,getx(),gety(), 50, 50);
        graphics.DrawString(Convert.ToString(number), drawFont, drawstring, getx() + 15, gety() + 12);
    }

}
public class Line
{
    private Point p1, p2; 
    int weight;
   
    public Line(Point p1,Point p2,int weight)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.weight = weight;
    }
    public Point GetPoint1()
    {
        return p1;
    }
    public Point GetPoint2()
    {
        return p2;
    }
    public int GetWeight()
    {
        return weight;
    }
    public void drawline(Graphics graphics,Pen drawpen,Font drawFont,SolidBrush drawstring)
    {
        graphics.DrawLine(drawpen,this.p1.getx() + 25, this.p1.gety() + 25, this.p2.getx() + 25, this.p2.gety() + 25);
        graphics.DrawString(Convert.ToString(this.weight), drawFont, drawstring, (this.p1.getx() + this.p2.getx()) / 2, (this.p1.gety() + this.p2.gety()) / 2);
    }
    public Boolean decisionunion(Tree t1,Tree t2)
    {
        if (t1.getreelist().Intersect(t2.getreelist()).Count()==t1.getreelist().Count())
        {
            return true;
        }
        else
            return false;
    }
 

}
public class Tree
{
    List<Point> list = new List<Point>();
    Point p;
    public Tree(Point p)
    {
        this.p = p;
        list.Add(p);
    }
    public List<Point> getreelist()
    {
        return list;
    }
    public void setlist(List<Point> list)
    {
        this.list = list;
    }

}
