using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Draw2
    {
        private List<City> city ;
        private int n;
        //最后一组人数
        private int end;

        public int End
        {
            get { return end; }
            set { end = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public List<City> City
        {
            get { return city; }
            //set { city = value; }
        }
        private List<Player> player ;

        public List<Player> Player
        {
            get { return player; }
        }
        private int[] disruptedArray;
        private int[] dis;
        private int size = 0;


        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        
        public Draw2(List<City> list)
        {
            size = list.Count;
            city = list;
            //进行抽签
            draw();
        }

        public Draw2(List<Player> list)
        {
            size = list.Count;
            player = list;

            //进行抽签
            //draw();
        }

        //生成抽签数字，放在数组中
        public int[] buidArray(int s)
        {
            List<int> li = new List<int>();
            for (int i = 1; i <= s; i++)
            {
                li.Add(i);
            }
            int[] array = li.ToArray();
            return array;
        }


        //将抽签结果更新到List中
        public void draw()
        {
            //根据size进行抽签
            if (size != 0)
            {
                int[] array = buidArray(size);
                //将抽签结果写入List
                if (city !=null)
                {
                    //输出数组类型
                    Item<int> disrupter = new Item<int>(array);
                    disruptedArray = disrupter.GetDisruptedItems();
                    for (int i = 0; i < city.Count; i++)
                    {
                        city[i].Order = disruptedArray[i];
                    }
                }
                 if (player !=null)
                {
                    disruptedArray=new int[player.Count+10];
                    for (int i = 0; i < disruptedArray.Length; i++)
                    {
                        disruptedArray[i] = 0;
                    }
                    //
                    int k=0;
                    for (int i = 0; i < n; i++)
                    {
                        Item<int> disrupter = new Item<int>(array);
                        dis= disrupter.GetDisruptedItems();
                        for (int o = 0; o < dis.Length ; o++)
                        {
                            disruptedArray[k] = dis[o];
                            k++;
                            //player[k++].Group = Convert.ToChar(i + 65);
                        }
                    }
                    //添加最后一组
                    //生成最后一组的随机数
                    List<int> le = new List<int>();
                    for (int i = 1; i <= end; i++)
                    {
                        le.Add(i);
                    }
                    int[] a = le.ToArray();
                    Item<int> dp = new Item<int>(a);
                    int[] di = dp.GetDisruptedItems();
                    for (int i = 0; i < end; i++)
                    {
                        disruptedArray[k++] = di[i];
                    }
                    //更新Player.Order
                    for (int i = 0; i < player.Count; i++)
                    {
                        player[i].Order = disruptedArray[i];
                    }
                    
                }


            }
            else
            {
                Console.WriteLine("size Error in Draw!");
            }

            

        }
     
        
        
    }
}
