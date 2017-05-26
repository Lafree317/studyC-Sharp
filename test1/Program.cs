using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace test1 {

    public class BaseClass {
        public static void Main(string[] args) {
            //SubClass.Start();
            //SignNumberClass.Start();
            //GradeClass.Start();
            //CircleClass.Start();
            //Triangle.Start();
            //AveragesClass.Start();
            //StarClass.Start();
            PrimeClass.Start();
            return;
        }

    }

    //1: 求1+2+3+ 。。。 +20 的结果。分别使用(while ,do_while ,for 三种循环语句)
    public class SubClass {
        public static void Start() {
            Console.WriteLine("While结果:" + SubWhile());
            Console.WriteLine("Do While结果:" + SubDoWhile());
            Console.WriteLine("for结果:" + SubFor());
            Console.ReadLine();
        }
        static int SubWhile() {
            var result = 0;
            var i = 0;
            while (i <= 20) {
                result += i;
                i++;
            }
            return result;

        }

        static int SubDoWhile() {
            var result = 0;
            var i = 0;
            do {
                result += i;
                i++;
            } while (i <= 20);
            return result;
        }

        static int SubFor() {
            var result = 0;
            for (int i = 0; i <= 20; i++) {
                result += i;
            }
            return result;
        }
    }

    //2: 键入10 个整数，统计其中正数(neg)、负数(pos)和零（zero）的个数并将三者输出。
    public class SignNumberClass {
        public static void Start() {

            Console.WriteLine("请输入正负整数以空格为间隔:");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            // 解析用户输入
            string[] nums = str.Split(new string[] { " " }, StringSplitOptions.None);
            int count = nums.Count<string>();

            int[] number = new int[3];

            for (int i = 0; i < count; i++) {
                string numStr = nums[i];

                // 如果含有字母就跳出单次循环
                if (IsExists(numStr)) {
                    Console.WriteLine(numStr + " 为非法字符");
                    continue;
                }
                int num = Convert.ToInt32(numStr);

                if (num > 0) {
                    number[0]++;
                } else if (num < 0) {
                    number[1]++;
                } else {
                    number[2]++;
                }
            }
            Console.WriteLine("正数:" + number[0]);
            Console.WriteLine("负数:" + number[1]);
            Console.WriteLine("等于0:" + number[2]);
            Console.ReadLine();
        }
        // 判断是否包含非数字内容
        public static bool IsExists(string str) {
            var a = Regex.IsMatch(str, "^[\u4e00-\u9fa5_a-zA-Z]+$");
            return a;
        }
    }

    //3: 输入一个学生的成绩（在0~100 分之间，超出此范围显示错），进行五级评分并显示。
    public class GradeClass {
        public static void Start() {
            while (true) {
                Console.WriteLine("请输入学生成绩,最多保留两位小数:");
                string str = Console.ReadLine();
                bool isNumber = IsExists(str);
                if (isNumber == false) {
                    Console.WriteLine("错误的输入请重新输入:");
                    continue;
                }
                int number = Convert.ToInt32(str);

                if (number >= 90) {
                    Console.WriteLine("A");
                } else if (number >= 80) {
                    Console.WriteLine("B");
                } else if (number >= 70) {
                    Console.WriteLine("C");
                } else if (number >= 60) {
                    Console.WriteLine("D");
                } else {
                    Console.WriteLine("E");
                }
            }
        }

        public static bool IsExists(string str) {
            return Regex.Matches(str, "^[0-9]+([.]{1}[0-9]{1,2})?$").Count > 0;
        }
    }


    //4: 输入一个圆半径（r），计算并输出圆的面积（s）和周长（l）
    public class CircleClass {
        public static void Start() {
            while (true) {
                Console.WriteLine("请输入圆的半径:");
                string str = Console.ReadLine();
                bool isNumber = IsExists(str);
                if (isNumber == false) {
                    Console.WriteLine("错误的输入请重新输入:");
                    continue;
                }
                int number = Convert.ToInt32(str);
                var perimeter = number * 2 * Math.PI;
                var area = number * number * Math.PI;
                Console.WriteLine("圆的周长:" + perimeter + " 面积:" + area);
            }
        }
        public static bool IsExists(string str) {
            return Regex.Matches(str, "^[0-9]+([.]{1}[0-9]{1,2})?$").Count > 0;
        }
    }

    /*
     5： 打印输出上三角,不能使用直接打印
    *
    **
    ***
    ****
    *****
     */
    public class Triangle {
        public static void Start() {
            int height = 5;
            string star = "*";
            for (int i = 0; i < height; i++) {
                Console.WriteLine(star);
                star += "*";
            }
            Console.ReadLine();
        }
    }



    //6.   声明并初始化长度为10的整型数组,输入10个数.输出其中大于平均值的数.
    public class AveragesClass {
        public static void Start() {
            Console.WriteLine("请输入10个整型数 以空格隔开:");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            // 解析用户输入
            string[] numStrArr = str.Split(new string[] { " " }, StringSplitOptions.None);

            // 获取素组长度 最大只保留前10个
            int count = numStrArr.Count<string>();
            if (count > 10) {
                count = 10;
            }

            int[] nums = new int[10];
            int result = 0;
            for (int i = 0; i < count; i++) {
                string numStr = numStrArr[i];

                // 如果含有字母就跳出单次循环
                if (IsExists(numStr)) {
                    Console.WriteLine(numStr + " 为非法字符");
                    continue;
                }
                int num = Convert.ToInt32(numStr);
                nums[i] = num;
                result += num;
            }
            int averages = result / count;
            Console.WriteLine("平均数:" + averages);
            Console.WriteLine("大于平均数的有:");
            foreach (int i in nums) {
                if (i > averages) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        // 判断是否包含非数字内容
        public static bool IsExists(string str) {
            var a = Regex.IsMatch(str, "^[\u4e00-\u9fa5_a-zA-Z]+$");
            return a;
        }
    }

    /* 
     7.   输入数字5输出
    * * *
    * * *
    * * *
    * * *
    *****
     */
    public class StarClass {
        public static void Start() {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            string all = "";
            string small = "";
            for (int i = 0; i < num; i++) {
                all += "*";
                if ((i % 2) == 0) {
                    small += "*";
                } else {
                    small += " ";
                }
            }

            for (int i = 0; i < num; i++) {
                if (i == num - 1) {
                    Console.WriteLine(all);
                } else {
                    Console.WriteLine(small);
                }
            }
            Console.ReadLine();
        }
    }

    //8.  模拟计算器输入两个数值与运算符,计算出相应运算结果
    public class CaculateClass {
        public static void Start() {
            int result = 0;
            while (true) {
                string str = Console.ReadLine();
                string[] numStrArr = str.Split(new string[] { " " }, StringSplitOptions.None);
                int num1 = Convert.ToInt32(numStrArr[0]);
                int num2 = Convert.ToInt32(numStrArr[2]);
                
                switch (numStrArr[1]) {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("输入有误");
                        break;
                }
                Console.WriteLine("结果为:" + result);
            }
        }
    }

    //9： 输出1-1000所有的素数。(素数： 不能被1与自身整除的数，是“素数”例如： 3，5，7，11,13，17，23。。。。。)
    public class PrimeClass {
        public static void Start() {
            Console.WriteLine("1-100的素数有:");
            for(int i = 0; i < 100; i++) {
                if (IsPrime(i)) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        static bool IsPrime(int n) {
            for(int i = 2; i < n; i++) {
                if ((n % i) == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
