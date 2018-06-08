using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nhap_tong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        //////////////////////////////////Chuyển đổi mảng kí tự thành mảng số nguyên
        public int [] Parse(string line) 
        { 
            string[] parts = line.Split(" ".ToCharArray(), //dấu phẩy là dấu ngăn cách cần bỏ đi
            StringSplitOptions.RemoveEmptyEntries); 
            return Array.ConvertAll<string, int>(parts,int.Parse); 
        }
        //////////////////////////Chuyển đổi mảng kí tự thành mảng số nguyên




        //////////////////////////Thuật toán mergesort tăng
           public     void Merge2Run(int []a,int n, int vt,int l)
        {
	        int []temp ;
            temp = new int[100];
	        int k;
	        int i = vt;  
	        int j = vt+l; 
	        k = 0;
	        while(!(!(i<vt+ l && i<n)&&!(j<vt+2* l && j<n)))
	        {
                if (SapTang.Checked == true)
                {
                    if ((i < vt + l && i < n && j < vt + 2 * l && j < n && a[i] < a[j]) || !(j < vt + 2 * l && j < n)) //a[i]<a[j]
                        temp[k++] = a[i++];
                    else
                        temp[k++] = a[j++];
                }
                else
                    if (SapGiam.Checked == true)
                    {


                        if ((i < vt + l && i < n && j < vt + 2 * l && j < n && a[i] > a[j]) || !(j < vt + 2 * l && j < n)) //a[i]<a[j]
                            temp[k++] = a[i++];
                        else
                            temp[k++] = a[j++];
                    }
	        }
	        for(i=0;i<k;i++)
		        a[vt+i]=temp[i];
	
	      
        } 
        public void MergeRun(int []a,int n, int l)
        {
	        int vt = 0;
	        while(vt<n)
	        {
		        Merge2Run(a,n,vt,l );
		        vt = vt + 2*l;
	        }
	
	
        }
        public void MergeSort(int []a, int n)
         {
	         int l = 1;
             HienThiTungBuoc.Text += "BƯỚC 1: Chia nhỏ mảng ban đầu thành các mảng con gồm 2 phần tử liên tiếp nhau" + "\n";
	         int i=0;
	         int j=0;
	         while(i<=n/2)
	         {
			        if(j<n)
			        {
                        int dem = i + 1;
				        HienThiTungBuoc.Text +="   Mảng thứ "+dem+": ";
				        HienThiTungBuoc.Text +=a[j]+"   ";
			        }
			        j++;
                    if (j < n)
                        HienThiTungBuoc.Text += a[j] + "\n";
                    else
                        HienThiTungBuoc.Text += "\n";
			        j++;
			        i++;
	         }
	         while(l<n)
	         {
		         MergeRun(a,n,l);
		         l = l * 2;
                 if (l < n)
                     HienThiTungBuoc.Text += "Sắp xếp lại lần lượt từng mảng kế tiếp nhau có tối đa " + l + " phần tử, ta được: " + "\n";
                 else
                     HienThiTungBuoc.Text += "Mảng đã sắp xếp xong !!!" + "\n";
   
                 for (int m = 0; m < n ; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    HienThiTungBuoc.Text += "\n" + "\n";
		      
	        }

         }

        //////////////////////////Thuật toán mergesort tăng

        //////////////////////////Thuật toán heapsort 
        public void Heapify(int[] a, int n, int vt) /// tăng
        {
	        while(vt<=n/2-1)
	        {
                int lc=2*vt+1;
                if (SapTang.Checked == true)
                {
                    if ((lc + 1) < n && a[lc + 1] > a[lc])
                        lc++;
                    if (a[lc] > a[vt])
                    {
                        int temp = a[lc];
                        a[lc] = a[vt];
                        a[vt] = temp;
                    }
                }
                else
                    if (SapGiam.Checked == true)
                    {
                        if ((lc + 1) < n && a[lc + 1] < a[lc])
                            lc++;
                        if (a[lc] < a[vt])
                        {
                            int temp = a[lc];
                            a[lc] = a[vt];
                            a[vt] = temp;
                        }
                    }
                vt = lc;
	        }
        }
        public void BuildHeap(int []a, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                    Heapify(a, n, i);
        }
        public void HeapSort(int []a, int n)
        {
	        BuildHeap(a,n);
            HienThiTungBuoc.Text += "*** BƯỚC 1: Sắp xếp mảng thành cây nhị phân. ***" + "\n";
            for (int j = 0; j < n; j++)
                HienThiTungBuoc.Text += a[j] + "  ||  ";
            HienThiTungBuoc.Text += "\n" + "\n" ;
	        int length=n;
            int i = 1;
	        while(length>1)
            {
                int temp = a[length - 1];
                a[length - 1] = a[0];
                a[0] = temp;

                length--;
                int m = i + 1;
                HienThiTungBuoc.Text += "		*** BƯỚC " + m + ". *** "+"\n";
                HienThiTungBuoc.Text += "+++ Hoán vị phần tử a[0] và phần tử a[" + length + "]" + "\n";
                
                for (int j = 0; j < length + 1; j++)
                    HienThiTungBuoc.Text += a[j] + "  ||  ";
                HienThiTungBuoc.Text += "\n";
                HienThiTungBuoc.Text += "+++ Loại bỏ phần tử cuối cùng ra khỏi cây nhị phân và sắp xếp lại cây nhị phân" + "\n";
                Heapify(a, length, 0);
                for (int j = 0; j < length; j++)
                    HienThiTungBuoc.Text += a[j] + "  ||  ";
                HienThiTungBuoc.Text += "\n";
              
                i++;
                HienThiTungBuoc.Text += "--- Mảng ban đầu qua " + i + " bước. ---" + "\n";
                for (int j = 0; j < n; j++)
                    HienThiTungBuoc.Text += a[j] + "  ||  ";
                HienThiTungBuoc.Text += "\n"+"\n";
	        }
        }

        //////////////////////////Thuật toán heapsort tăng

        //////////////////////////Thuật toán quicksort tăng

        public void Split(int []a, int n, int TrongTai, int []b, out int k, int []c, out int l)
        {
	        k=l=0;
	        for(int i=0; i<n; i++)
	        {
                if (SapTang.Checked == true)
                {
                    if (a[i] < TrongTai)
                        b[k++] = a[i];
                    else
                        if (a[i] > TrongTai)
                            c[l++] = a[i];
                }
                else
                    if (SapGiam.Checked == true)
                    {
                        if (a[i] > TrongTai)
                            b[k++] = a[i];
                        else
                            if (a[i] < TrongTai)
                                c[l++] = a[i];
                    }
	        }
        }
        public void QuickSort(int[] a, int n)
        {
	        if(n<1)
		        return;
            int[] b;
            b = new int[100];
            int[] c;
            c = new int[100];
            int[] temp;
            temp = new int[100];
            int k, l;
            int TrongTai = a[0];
            ///// Hiển thị từng bước
            HienThiTungBuoc.Text += "\n"+"*** Chia nhỏ mảng: ";
            for (int i = 0; i < n; i++)
                HienThiTungBuoc.Text += a[i] + "  ||  ";
            HienThiTungBuoc.Text += "\n";
            HienThiTungBuoc.Text += "*** Chọn trọng tài là : " + a[0] + "\n";
	        Split(a,n,TrongTai,b,out k,c,out l);
            HienThiTungBuoc.Text += "Ta được mảng con thứ 1 gồm các phần tử nhỏ hơn "+a[0]+": ";
            for (int i = 0; i < k; i++)
                HienThiTungBuoc.Text += b[i] + "  ||  ";
            HienThiTungBuoc.Text += "\n";
            HienThiTungBuoc.Text += "Ta được mảng con thứ 2 gồm các phần tử lớn hơn " + a[0] + ": ";
            for (int i = 0; i < l; i++)
                HienThiTungBuoc.Text += c[i] + "  ||  ";
            HienThiTungBuoc.Text += "\n";
             ///////Hiển thị từng bước
	        QuickSort(b,k);
	        QuickSort(c,l);
	        for(int i=0; i<k; i++)
		        a[i]=b[i];
	        for(int i=0; i<n-k-l; i++)
		        a[i+k]=TrongTai;
	        for(int i=0; i<l; i++)
		        a[i+(n-k-l)+k]=c[i];
            if(SapTang.Checked== true)
                HienThiTungBuoc.Text += "Gộp các mảng con vừa chia nhỏ lại theo thứ tự tăng dần ta được mảng: ";
            else
                if(SapGiam.Checked== true)
                    HienThiTungBuoc.Text += "Gộp các mảng con vừa chia nhỏ lại theo thứ tự giảm dần ta được mảng: ";
            for (int i = 0; i < n; i++)
                HienThiTungBuoc.Text += a[i] + "  ||  ";
            HienThiTungBuoc.Text += "\n";
        }
        //////////////////////////Thuật toán quicksort tăng

        //////thuật toán interchange sort tăng



        public void InterchangeSort(int []a,int n)
        {
            int dem = 1;
            for (int i = 0; i <= n - 2; i++)
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (SapTang.Checked == true)
                    {
                        HienThiTungBuoc.Text += " BƯỚC " + dem + ": so sánh phần tử a[" + i + "] và phần tử a[" + j + "]: ";
                        if (a[i] > a[j])
                        {
                            HienThiTungBuoc.Text += "\n" + "    Ta thấy phần tử a[" + i + "]=" + a[i] + " lớn hơn phần tử a[" + j + "]=" + a[j] + " ta hoán vị hai phần tử này với nhau" + "\n";
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                            HienThiTungBuoc.Text += "Mảng sau khi hoán vị: ";
                            for (int m = 0; m < n; m++)
                                HienThiTungBuoc.Text += a[m] + "  ||  ";
                            HienThiTungBuoc.Text += "\n";
                        }
                        else
                            HienThiTungBuoc.Text += "Hai phần tử thỏa điều kiện tăng dần" + "\n";
                        dem++;
                    }
                    else
                        if (SapGiam.Checked == true)
                        {
                            HienThiTungBuoc.Text += " BƯỚC " + dem + ": so sánh phần tử a[" + i + "] và phần tử a[" + j + "]: ";
                            if (a[i] < a[j])
                            {
                                HienThiTungBuoc.Text += "\n" + "    Ta thấy phần tử a[" + i + "]=" + a[i] + " nhỏ hơn phần tử a[" + j + "]=" + a[j] + " ta hoán vị hai phần tử này với nhau" + "\n";
                                int temp = a[i];
                                a[i] = a[j];
                                a[j] = temp;
                                HienThiTungBuoc.Text += "Mảng sau khi hoán vị: ";
                                for (int m = 0; m < n; m++)
                                    HienThiTungBuoc.Text += a[m] + "  ||  ";
                                HienThiTungBuoc.Text += "\n";
                            }
                            else
                                HienThiTungBuoc.Text += "Hai phần tử thỏa điều kiện giảm dần" + "\n";
                            dem++;
                        }

                }
        }


        //////thuật toán interchange sort tăng

        
        ////////// thuật toán bubble sort  tăng
        
        public void BubbleSort(int []a,int n)
        {
	        int dem=1;
	        for(int i=0;i<n-1;)
	        {
		        int vt = n-1;
		        for(int j=n-1;j>=i+1;j--)
		        {
                    if (SapTang.Checked == true)
                    {
                        int tempj = j - 1;
                        HienThiTungBuoc.Text += " BƯỚC " + dem + ": so sánh phần tử a[" + j + "] và phần tử a[" + tempj + "]: ";
                        if (a[j] < a[j - 1])
                        {
                            HienThiTungBuoc.Text += "\n" + "    Ta thấy phần tử a[" + j + "]=" + a[j] + " nhỏ hơn phần tử a[" + tempj + "]=" + a[j-1] + " ta hoán vị hai phần tử này với nhau" + "\n";
                            int temp = a[j];
                            a[j] = a[j - 1];
                            a[j - 1] = temp;
                            vt = j;
                            HienThiTungBuoc.Text += "Mảng sau khi hoán vị: ";
                            for (int m = 0; m < n; m++)
                                HienThiTungBuoc.Text += a[m] + "  ||  ";
                            HienThiTungBuoc.Text += "\n";
                        }
                        else
                            HienThiTungBuoc.Text += "Hai phần tử thỏa điều kiện tăng dần" + "\n";
                        dem++;
                    }
                    else
                        if (SapGiam.Checked == true)
                        {
                            int tempj = j - 1;
                            HienThiTungBuoc.Text += " BƯỚC " + dem + ": so sánh phần tử a[" + j + "] và phần tử a[" + tempj + "]: ";
                            if (a[j] > a[j - 1])
                            {
                                HienThiTungBuoc.Text += "\n" + "    Ta thấy phần tử a[" + j + "]=" + a[j] + " lớn hơn phần tử a[" + tempj + "]=" + a[j-1] + " ta hoán vị hai phần tử này với nhau" + "\n";
                                int temp = a[j];
                                a[j] = a[j - 1];
                                a[j - 1] = temp;
                                vt = j;
                                HienThiTungBuoc.Text += "Mảng sau khi hoán vị: ";
                                for (int m = 0; m < n; m++)
                                    HienThiTungBuoc.Text += a[m] + "  ||  ";
                                HienThiTungBuoc.Text += "\n";
                            }
                            else
                                HienThiTungBuoc.Text += "Hai phần tử thỏa điều kiện giảm dần" + "\n";
                            dem++;
                        }
		        }
		        i = vt;
	        }
        }

        /////// thuật toán bubble sort tăng
 
        ///////// thuật toán selectionsort tăng
        public void SelectionSort(int []a, int n)
        {
	        int dem=1;
	        for(int i=0;i<=n-2;i++)
	        {
		        int lc = i;
                if (SapTang.Checked == true)
                {
                    for (int j = i; j <= n - 1; j++)
                        if (a[j] < a[lc])
                            lc = j;
                    if (lc != i)
                    {
                        int temp2 = n - 1;
                        HienThiTungBuoc.Text += "    BƯỚC" + dem + "\n";
                        HienThiTungBuoc.Text += "Tìm phần tử có giá trị nhỏ nhất trong phạm vi từ a[" + i + "] đến a[" + temp2 + "] là a[" + lc + "] = " + a[lc] + "\n";
                        HienThiTungBuoc.Text += "Hoán vị giá trị của a[ " + lc + " ] và a[ " + i + " ] cho nhau, mảng trở thành: " + "\n";
                        int temp = a[i];
                        a[i] = a[lc];
                        a[lc] = temp;
                        for (int m = 0; m < n; m++)
                            HienThiTungBuoc.Text += a[m] + "  ||  ";
                        HienThiTungBuoc.Text += "\n";
                        dem++;
                    }
                }
                else
                    if (SapGiam.Checked == true)
                    {
                        for (int j = i; j <= n - 1; j++)
                            if (a[j] > a[lc])
                                lc = j;
                        if (lc != i)
                        {
                            int temp2 = n - 1;
                            HienThiTungBuoc.Text += "    BƯỚC" + dem + "\n";
                            HienThiTungBuoc.Text += "Tìm phần tử có giá trị lớn nhất trong phạm vi từ a[" + i + "] đến a[" + temp2 + "] là a[" + lc + "] = " + a[lc] + "\n";
                            HienThiTungBuoc.Text += "Hoán vị giá trị của a[ " + lc + " ] và a[ " + i + " ] cho nhau, mảng trở thành: " + "\n";
                            int temp = a[i];
                            a[i] = a[lc];
                            a[lc] = temp;
                            for (int m = 0; m < n; m++)
                                HienThiTungBuoc.Text += a[m] + "  ||  ";
                            HienThiTungBuoc.Text += "\n";
                            dem++;
                        }
                    }
	        }
        }

        ////////////////hàm kiểm tra tính đúng sai của dãy số nhập vào tăng
        /*
         * 2. số lượng phần tử nhập vào nhiều hơn số lượng phần tử quy định
         * 1. số lượng phần tử nhập vào ít hơn số lượng phần tử quy định
         * 0. mảng hợp lệ
         * 3. mảng rổng;
         */
        public int KiemTraDungSai(string DaySo)
        {
            int n = DaySo.Length; 
            if (n == 0)
                return 3;
            int[] a = new int[100];
            a = Parse(DaySo);
            n = a.Length;
            int SoPhanTu = Convert.ToInt32(soluongphantu.Value);// chuyển kiểu numberupdown trở thành số nguyên
            if (n > SoPhanTu)
                return 2;
            else
                if (n < SoPhanTu)
                    return 1;
            return 0;
        }

        ////////////////hàm kiểm tra tính đúng sai của dãy số nhập vào


        ///////// code chương trình tăng
        public string SELECTIONSORT()
        {
            string temp = "void SelectionSort(int a[], int n)" + "\n";
            temp +="{" + "\n";
	        temp +="    for(int i=0;i<=n-2;i++)" + "\n";
	        temp +="    {" + "\n";
		    temp +="        int lc = i;" + "\n";
		    temp +="        for(int j=i;j<=n-1;j++)" + "\n";
            if(SapTang.Checked== true)
                temp +="            if(a[j]<a[lc])" + "\n";
            else
                if(SapGiam.Checked== true)
                    temp +="            if(a[j]>a[lc])" + "\n";
			temp +="	            lc = j;" + "\n";
		    temp +="        int temp = a[i];" + "\n";
		    temp +="        a[i] = a[lc];" + "\n";
		    temp +="        a[lc] = temp;" + "\n";
	        temp +="    }" + "\n";
            temp += "}" + "\n";
            return temp;
        }
        public string BUBBLESORT()
        {
            string temp = "void BubbleSort ( int a[ ], int n )" + "\n";
            temp +="{" + "\n";
	        temp +="    for ( int i = 0 ; i < n - 1 ; )" + "\n";
	        temp +="    {" + "\n";
		    temp +="        int vt = n - 1;" + "\n";
		    temp +="        for ( int j = n - 1; j >= i + 1; j-- )" + "\n";
            if(SapTang.Checked== true)
                temp +="            if ( a[ j ] < a[ j - 1 ] )" + "\n";
            else
                 if(SapGiam.Checked== true)
                    temp +="            if ( a[ j ] > a[ j - 1 ] )" + "\n";
			temp +="            {" + "\n";
			temp +="	            int temp = a[ j ];" + "\n";
			temp +="	            a[ j ] = a[ j - 1 ];" + "\n";
			temp +="	            a[ j - 1 ] = temp;" + "\n";
			temp +="	            vt = j;" + "\n";
			temp +="            }" + "\n";
		    temp +="        i = vt;" + "\n";
	        temp +="    }" + "\n";
            temp += "}" + "\n";
            return temp;
        }
        public string INTERCHANGESORT()
        {
            string temp = "void InterchangeSort(int a[],int n)"+"\n";
            temp +="{"+"\n";
	        temp +="    for(int i=0;i<=n-2;i++)"+"\n";
		    temp +="        for(int j=i+1;j<=n-1;j++)"+"\n";
            if(SapTang.Checked== true)
                temp +="            if(a[i]>a[j])"+"\n";
            else
                 if(SapGiam.Checked== true)
                     temp +="            if(a[i]<a[j])"+"\n";
			temp +="            {"+"\n";
			temp +="	            int temp=a[i];"+"\n";
			temp +="	            a[i]=a[j];"+"\n";
			temp +="	            a[j]=temp;"+"\n";
			temp +="            }"+"\n";
            temp +="}" + "\n";
            return temp;         
        }
        public string MERGESORT()
        {
            string temp="void Merge2Run ( int a[ ],int n, int vt, int l )" + "\n";
            temp +="{" + "\n";
	        temp +="    int temp[ 100 ];" + "\n";
	        temp +="    int k;" + "\n";
	        temp +="    int i = vt ;" + "\n";
	        temp +="    int j = vt + l;" + "\n"; 
	        temp +="    k = 0;" + "\n";
	        temp +="    while ( ! ( ! ( i < vt + l && i < n ) && ! ( j < vt + 2 * l && j < n ) ) )" + "\n";
	        temp +="    {" + "\n";
            if(SapTang.Checked== true)
                 temp +="        if ( ( i < vt + l && i < n && j < vt + 2 * l && j < n && a[ i ] < a[ j ] ) || ! ( j < vt + 2 * l && j < n ) ) " + "\n";
            else
                   if(SapGiam.Checked== true)
                       temp +="        if ( ( i < vt + l && i < n && j < vt + 2 * l && j < n && a[ i ] > a[ j ] ) || ! ( j < vt + 2 * l && j < n ) ) " + "\n";
		    
			temp +="            temp[ k++ ] = a[ i++ ];" + "\n";
		    temp +="        else" + "\n";
			temp +="            temp[ k++ ] = a[ j++ ];" + "\n";
	        temp +="    }" + "\n";
	        temp +="    for( i = 0; i < k; i ++ )" + "\n";
		    temp +="        a[ vt + i ] = temp[ i ];" + "\n";
            temp += "}" + "\n" + "\n";;

            temp +="void MergeRun ( int a[ ],int n, int l )" + "\n";
            temp +="{" + "\n";
	        temp +="    int vt = 0;" + "\n";
	        temp +="    while ( vt < n )" + "\n";
	        temp +="    {" + "\n";
		    temp +="        Merge2Run ( a, n, vt, l );" + "\n";
		    temp +="        vt = vt + 2*l;" + "\n";
	        temp +="    }" + "\n";
            temp += "}" + "\n" + "\n";

            temp += "void MergeSort ( int a[ ], int n )" + "\n";
            temp +="{" + "\n";
	        temp +="    int l = 1;" + "\n";
	        temp +="    while ( l < n )" + "\n";
	        temp +="    {" + "\n";
		    temp +="         MergeRun ( a, n, l );" + "\n";
		    temp +="         l = l * 2;" + "\n";
	        temp +="    }"+"\n";
            temp += "}" + "\n";
            return temp;   
        }
        public string QUICKSORT() ////// QUICKSORT tăng
        {
            string temp ="void Split ( int a[ ], int n, int TrongTai, int b[ ], int &k, int c[ ], int &l )"+"\n";
            temp +="{"+"\n";
	        temp +="    k = l = 0;"+"\n";
	        temp +="    for ( int i = 0; i < n; i++)"+"\n";
            if (SapTang.Checked == true)
            {
                temp += "        if ( a[ i ] < TrongTai )" + "\n";
                temp += "            b[ k++ ]=a [ i ];" + "\n";
                temp += "        else" + "\n";
                temp += "            if( a[i] > TrongTai )" + "\n";
                temp += "	            c[ l++ ] = a[ i ];" + "\n";
            }
            else
                if (SapGiam.Checked == true)
                {
                    temp += "        if ( a[ i ] > TrongTai )" + "\n";
                    temp += "            b[ k++ ]=a [ i ];" + "\n";
                    temp += "        else" + "\n";
                    temp += "            if( a[i] < TrongTai )" + "\n";
                    temp += "	            c[ l++ ] = a[ i ];" + "\n";
                    
                }
            temp += "}" + "\n" + "\n";
            temp +="void QuickSort ( int a[ ], int n)"+"\n";
            temp +="{"+"\n";
	        temp +="    if( n  < 1 )"+"\n";
		    temp +="        return ;"+"\n";
	        temp +="    int TrongTai = a[ 0 ];"+"\n";
	        temp +="    int b[ 100 ], c[ 100 ], k ,l;"+"\n";
	        temp +="    Split ( a, n, TrongTai, b, k, c, l );"+"\n";
	        temp +="    QuickSort ( b, k);"+"\n";
	        temp +="    QuickSort( c, l);"+"\n";
	        temp +="    for ( int i = 0; i < k; i++ )"+"\n";
		    temp +="        a[ i ] = b [ i ];"+"\n";
	        temp +="    for ( int i = 0; i < n - k - l; i++ )"+"\n";
		    temp +="        a[ k + i ] = TrongTai;"+"\n";
	        temp +="    for ( int i = 0; i < l; i++)"+"\n";
		    temp +="        a[ k + i + ( n - k - l ) ] = c[ i ];"+"\n";
            temp += "}" + "\n";
            return temp;
        }

        public string HEAPSORT() /////HEAPSORT tăng
        { 
            string temp="void Heapify ( int a[ ], int n, int &vt )"+"\n";
            temp +="{"+"\n";
            temp +="    while( vt <= n/2 - 1 )"+"\n";
            temp +="    {"+"\n";
            temp +="        int lc= 2*vt + 1;"+"\n";
            if (SapTang.Checked == true)
            {
                temp += "        if ( a[ lc+1 ] > a[ lc ] && ( lc+1 ) < n)" + "\n";
                temp += "           lc++;" + "\n";
                temp += "        if ( a[ lc ]> a[ vt ])" + "\n";
                
            }
            else
                if (SapGiam.Checked == true)
                {
                    temp += "        if ( a[ lc+1 ] < a[ lc ] && ( lc+1 ) < n)" + "\n";
                    temp += "           lc++;" + "\n";
                    temp += "        if ( a[ lc ]< a[ vt ])" + "\n";
                }
      
            temp +="           Swap ( a[ lc ] , a[ vt ] );"+"\n";
            temp +="        vt = lc;"+"\n";
            temp +="    }"+"\n"; 
            temp +="}"+"\n"+"\n"+"\n";
            temp +="void BuilHeap ( int a[ ], int n )" +"\n";
            temp +="{"+"\n";
            temp +="    for ( int i = n/2 - 1; i >= 0; i-- )"+"\n";
            temp +="        Heapify ( a, n, i );"+"\n";
            temp +="}"+"\n";
            temp +="void HeapSort ( int a[ ], int n )" + "\n";
            temp +="{"+"\n";
	        temp +="    int lenght = n - 1;"+"\n";
	        temp +="    BuilHeap ( a, n );"+"\n";
	        temp +="    while ( lenght > 0 )"+"\n";
	        temp +="    {"+"\n";
		    temp +="        Swap( a[lenght], a[0] );"+"\n";
		    temp +="        lenght--;"+"\n";
		    temp +="        int i = 0;"+"\n";
		    temp +="        Heapify ( a, lenght, i);"+"\n";
	        temp +="    }"+"\n"; 
            temp +="}" + "\n";
            
            return temp;
        
        }

        //////// code chương trình

        ///////// code ý tưởng
        public string YTUONGINTERCHANGSORT()
        {
            string temp = "     Xuất phát từ đầu dãy, tìm tất các các nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi chỗ 2 phần tử trong cặp nghịch thế. Lặp lại xử lý trên với phần tử kế trong dãy.";
            return temp;
        }
        public string YTUONGBUBBLESORT()
        {
            string temp;
            temp = "";
            if(SapTang.Checked== true)
                 temp = "-    Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đứng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i." + "\n";
            else
                if(SapGiam.Checked== true)
                     temp = "-    Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử lớn hơn trong cặp phần tử đó về vị trí đứnng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i." + "\n";
            
            temp += "-    Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét." + "\n";
            return temp;

        }
        public string YTUONGSELECTIONSORT()
        {
            string temp;
            temp = "";
            if (SapTang.Checked == true)
            {
                temp = "   - Bước 0: Tìm vị trí giá trị nhỏ nhất trong phạm vi [0,n-1] và hoán vị giá trị tại vị trí này và phần tử a[0]." + "\n";
                temp += "   - Bước 1: Tìm vị trí giá trị nhỏ nhất trong phạm vi [1,n-1] và hoán vị giá trị tại vị trí này và phần tử a[1]." + "\n";
                temp += "   - …" + "\n";
                temp += "   - Bước i: Tìm vị trí giá trị nhỏ nhất trong phạm vi [i,n-1] và hoán vị giá trị tại vị trí này và phần tử a[i]." + "\n";
                temp += "   - …" + "\n";
                temp += "   - Bước n-2: Tìm vị trí giá trị nhỏ nhất trong phạm vi [n-2,n-1] và hoán vị giá trị tại vị trí này và phần tử a[n-2]." + "\n";
            }
            else
                if (SapGiam.Checked == true)
                {
                    temp = "   - Bước 0: Tìm vị trí giá trị lớn nhất trong phạm vi [0,n-1] và hoán vị giá trị tại vị trí này và phần tử a[0]." + "\n";
                    temp += "   - Bước 1: Tìm vị trí giá trị lớn nhất trong phạm vi [1,n-1] và hoán vị giá trị tại vị trí này và phần tử a[1]." + "\n";
                    temp += "   - …" + "\n";
                    temp += "   - Bước i: Tìm vị trí giá trị lớn nhất trong phạm vi [i,n-1] và hoán vị giá trị tại vị trí này và phần tử a[i]." + "\n";
                    temp += "   - …" + "\n";
                    temp += "   - Bước n-2: Tìm vị trí giá trị lớn nhất trong phạm vi [n-2,n-1] và hoán vị giá trị tại vị trí này và phần tử a[n-2]." + "\n";
                }
            return temp;
            
        }


        public string YTUONGHEAPSORT()
        {
            string temp="- BƯỚC 1 – Xây dựng Heap: Sử dụng thao tác Heapify để chuyển đổi một mảng bình thường thành Heap."+"\n";
            temp +="    + Tất cả các phần tử trên mảng có chỉ số [n/2] đến [n-1] đều là nút lá."+"\n";
            temp +="    + Mỗi nút lá được xem là Heap có duy nhất một phần tử."+"\n";
            temp +="    + Thực hiện thao tác Heapify trên các phần tử có chỉ số từ [n/2]-1 tới 0 ta sẽ tạo ra một Heap có n phần tử."+"\n";
            temp +="- BƯỚC 2 – Sắp xếp."+"\n";
            temp +="    + Hoán vị phần tử cuối cùng của Heap với phần tử đầu tiên của Heap."+"\n";
            temp +="    + Loại bỏ phần tử cuối cùng."+"\n";
            temp +="    + Thực hiện thao tác Heapify để điều chỉnh phần tử đầu tiên." + "\n";
            return temp;
        }
        public string YTUONGQUICKSORT()
        {
            string temp = "- Thuật toán quick sort chia không gian cần sắp xếp thành 2 không gian con là không gian con 1 và không gian con 2. Không gian con 1 là không gian mà tất cả các phần tử thuộc không gian này đều nhỏ hơn tất cả các phần tử thuộc không gian con 2." + "\n";
            temp +="    + Nếu không gian con thứ nhất có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Quick Sort." +"\n";
            temp +="    + Nếu không gian con thứ hai có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Quick Sort."+"\n";
            return temp;
        }
        public string YTUONGMERGESORT()
        {
            string temp="- Thuật toán Merge Sort chia không gian cần sắp xếp thành 2 không gian con."+"\n";
            temp +="    + Nếu không gian con thứ nhất có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Merge Sort."+"\n";
            temp +="    + Nếu không gian con thứ hai có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Merge Sort."+"\n";
            temp += "- Trộn 2 không gian con đã được sắp xếp lại với nhau." + "\n";
            return temp;
        }

        ///////////code ý tưởng

         /////////Hàm kích nút thực hiện (HÀM CHÍNH)
        private void label1_Click(object sender, EventArgs e)
        {

            int KiemTra = KiemTraDungSai(dayso.Text);
            if (KiemTra == 3)
            {
                MessageBox.Show("Mảng rỗng. Mời bạn nhập lại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (KiemTra == 2)
            {
                MessageBox.Show("Số lượng phần tử nhập vào lớn hơn số lượng phần tử quy định", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (KiemTra == 1)
            {
                MessageBox.Show("Số lượng phần tử nhập vào nhỏ hơn số lượng phần tử quy định", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SapTang.Checked == false && SapGiam.Checked == false)
                MessageBox.Show("Bạn chưa nhập lựa chọn sắp xếp tăng hoặc giảm", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int[] a = new int[100];
                a = Parse(dayso.Text);
                int n = a.Length;
                HienThiTungBuoc.Text += "MẢNG CẦN ĐƯỢC SẮP XẾP LÀ: ";
                for (int m = 0; m < n; m++)
                    HienThiTungBuoc.Text += a[m] + "  ||  ";
                HienThiTungBuoc.Text += "\n" + "\n";
                if (SapTang.Checked == true)
                    HienThiTungBuoc.Text += "Mảng đang được sắp xếp theo chiều tăng dần" + "\n" ;
                else
                    if(SapGiam.Checked== true)
                        HienThiTungBuoc.Text += "Mảng đang được sắp xếp theo chiều giảm dần" + "\n";
                if (LuaChonThuatToan.Text == "1. Interchange Sort")
                {
                    CodeThuatToan.Text = INTERCHANGESORT();
                    YTuong.Text = YTUONGINTERCHANGSORT();
                    HienThiTungBuoc.Text += "Thực hiện theo thuật toán Interchange Sort" + "\n";
                    InterchangeSort(a, n);
                    MessageBox.Show("Hoàn Thành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTungBuoc.Text += "MẢNG SAU KHI SẮP XẾP XONG LÀ: ";
                    for (int m = 0; m < n; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    return;
                }
                if (LuaChonThuatToan.Text == "2. Bubble Sort")
                {
                    CodeThuatToan.Text = BUBBLESORT();
                    YTuong.Text = YTUONGBUBBLESORT();
                    HienThiTungBuoc.Text += "Thực hiện theo thuật toán Bubble Sort" + "\n";
                    BubbleSort(a, n);
                    MessageBox.Show("Hoàn Thành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTungBuoc.Text += "MẢNG SAU KHI SẮP XẾP XONG LÀ: ";
                    for (int m = 0; m < n; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    return;
                }
                if (LuaChonThuatToan.Text == "3. Selection Sort")
                {
                    CodeThuatToan.Text = SELECTIONSORT();
                    YTuong.Text = YTUONGSELECTIONSORT();
                    HienThiTungBuoc.Text += "Thực hiện theo thuật toán Selection Sort" + "\n";
                    SelectionSort(a, n);
                    MessageBox.Show("Hoàn Thành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTungBuoc.Text += "MẢNG SAU KHI SẮP XẾP XONG LÀ: ";
                    for (int m = 0; m < n; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    return;
                }
                if (LuaChonThuatToan.Text == "4. Heap Sort")
                {
                    CodeThuatToan.Text = HEAPSORT();
                    YTuong.Text = YTUONGHEAPSORT();
                    HienThiTungBuoc.Text += "Thực hiện theo thuật toán Heap Sort" + "\n";
                    HeapSort(a, n);
                    MessageBox.Show("Hoàn Thành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTungBuoc.Text += "MẢNG SAU KHI SẮP XẾP XONG LÀ: ";
                    for (int m = 0; m < n; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    return;
                }
                if (LuaChonThuatToan.Text == "5. Merge Sort")
                {
                    CodeThuatToan.Text = MERGESORT();
                    YTuong.Text = YTUONGMERGESORT();
                    HienThiTungBuoc.Text += "Thực hiện theo thuật toán Merge Sort" + "\n";
                    MergeSort(a, n);
                    MessageBox.Show("Hoàn Thành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTungBuoc.Text += "MẢNG SAU KHI SẮP XẾP XONG LÀ: ";
                    for (int m = 0; m < n; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    return;
                }
                if (LuaChonThuatToan.Text == "6. QuickSort")
                {
                    CodeThuatToan.Text = QUICKSORT();
                    YTuong.Text = YTUONGQUICKSORT();
                    HienThiTungBuoc.Text += "Thực hiện theo thuật toán quick Sort" + "\n";
                    QuickSort(a, n);
                    MessageBox.Show("Hoàn Thành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTungBuoc.Text += "MẢNG SAU KHI SẮP XẾP XONG LÀ: ";
                    for (int m = 0; m < n; m++)
                        HienThiTungBuoc.Text += a[m] + "  ||  ";
                    return;
                }
                else
                {
                    MessageBox.Show("Chưa nhập thuật toán", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            

        
        }
        /////////Hàm kích nút thực hiện (HÀM CHÍNH)

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void xuatra_Enter(object sender, EventArgs e)
        {

        }

        private void HienThiTungBuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayso_TextChanged(object sender, EventArgs e)
        {

        }

        public void NgauNhien_Click(object sender, EventArgs e)
        {
            dayso.Text = "";
            int DoDai = Convert.ToInt32(soluongphantu.Value);
            Random x = new Random();
            for (int i = 0; i < DoDai; i++)
            {
                int n= x.Next(0, 100);
                dayso.Text += n + " ";
            }
        }

        private void ReSet_Click(object sender, EventArgs e)
        {
            dayso.Text = "";
            LuaChonThuatToan.Text = "";
            YTuong.Text = "";
            CodeThuatToan.Text = "";
            HienThiTungBuoc.Text = "";
            SapTang.Checked = false;
            SapGiam.Checked = false;
            soluongphantu.ResetText();


        }

        private void YTuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void soluongphantu_ValueChanged(object sender, EventArgs e)
        {

        }

        public void SapTang_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void đạtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hahahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" *** Tại ô <Nhập số phần tử của mảng> bạn nhập một số nguyên dương từ 1 đến 100 chính là số lượng phần tử của mảng được sắp xếp \n *** Tại ô <Nhập dãy số> bạn Nhập một dãy số nguyên tùy ý với quy định mỗi số liên tiếp nhau được cách nhau bới 1 hoặc nhiều khoảng trắng \n *** Tại nút <Nhập Ngẫu Nhiên> bạn có thể không thực hiện thao tác <Nhập dãy số> mà để cho chương trình tự nhập vào một dãy số ngẫu nhiên\n *** Tại ô <Chọn Thuật Toán> bạn lựa chọn thuật toán mình muốn chương trình cài đặt\n *** Tại lựa chọn <Cách Sắp Xếp> chọn 1 trong 2 cách sắp xếp tăng hoặc giảm\n *** Tại nút <SẮP XẾP> bạn click để chương trình thực hiện và mô phỏng từng bước\n *** Tại nút <RESET> bạn click để chương trình trở về trạng thái mặc đinh bạn đâu\n *** CHÚ Ý: Yêu cầu nhập đầy đủ và đúng các thông tin mà chương trình yêu cầu để chương trình có thể thực hiện  ","HƯỚNG DẪN SỬ DỤNG",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" PHẦN MỀM MÔ PHỎNG THỰC HIỆN THUẬT TOÁN SẮP XẾP\n Thiết Kế Bởi: Phùng Văn Đạt\n Mã số sinh viên: 15520109\n Lớp: IT003.G26\n", "GIỚI THIỆU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
