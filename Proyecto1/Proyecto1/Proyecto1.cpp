#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>
#include <fstream>
#include <queue>
#include <stdlib.h>
using namespace cv;
using namespace std;
void grises(Mat org, Mat sal);
void des_grs(Mat grs, Mat img_out);
void umbral(Mat img_gris, Mat sal, float n);
void operaciones_img(Mat in1, Mat in2, Mat out);
void aritmeticas(Mat in, Mat out, int s, float fact); //	1 = +, 2 = -, 3 = *, 4 = /
void negativo(Mat in, Mat out);
void invertir_v(Mat in, Mat out);
void f_promedio(Mat in, Mat out);
void conteo(Mat in);
void dilatacion(Mat in, Mat aux, int n);
void erosion(Mat in, Mat out, int n);
void apertura(Mat in, Mat out, int n);
void cierre(Mat in, Mat out, int n);
void histograma(Mat in, Mat out);
int video(void);
void bordes(Mat in, Mat out, float x);

int main() {
	//video();
	Mat image = imread("C:/Users/emi_s/Pictures/SVC/tres.jpg");
	cout << "canales:" << image.channels() << " filas: " << image.rows << " columnas: " << image.cols << endl;
	imshow("Original", image);
	Mat griss(image.rows, image.cols, CV_32FC1);
	Mat aux(image.rows, image.cols, CV_32FC1);
	Mat aux1(image.rows, image.cols, CV_32FC1);
	Mat umb(image.rows, image.cols, CV_32FC1);
	Mat img_salida(image.rows, image.cols, CV_8UC1);
	grises(image, griss);
	des_grs(griss, img_salida);
	imshow("gris", img_salida);
	bordes(griss, aux, 25.0);
	des_grs(aux, img_salida);
	imshow("bordes", img_salida);
	umbral(aux, umb, 80.0);
	des_grs(umb, img_salida);
	imshow("Umbral", img_salida);
	negativo(umb, aux);
	f_promedio(aux, aux1);
	des_grs(aux1, img_salida);
	imshow("Promedio", img_salida);
	conteo(aux1);
	des_grs(aux1, img_salida);
	imshow("Salida", img_salida);
	waitKey(0);
}
void grises(Mat org, Mat sal) {
	Mat aux(org.rows, org.cols, CV_32FC3);
	org.convertTo(aux, CV_32FC3);
	for (int i = 0; i < org.rows; i++)
		for (int j = 0; j < org.cols; j++)
		{
			Vec3f pixel = aux.at<Vec3f>(i, j);
			sal.at<float>(i, j) = 0.114 * pixel[0] + 0.587 * pixel[1] + 0.299 * pixel[2];
			//			sal.at<float>(i, j) = (pixel[0] + pixel[1] + pixel[2]) / 3.0;
		}
}
void umbral(Mat img_gris, Mat sal, float n) {
	for (int i = 0; i < img_gris.rows; i++)
		for (int j = 0; j < img_gris.cols; j++)
		{
			if (img_gris.at<float>(i, j) <= n)
				sal.at<float>(i, j) = 0.0;
			else
				sal.at<float>(i, j) = 255.0;
		}
}
void des_grs(Mat gris, Mat img_out) {
	gris.convertTo(img_out, CV_8UC1);
}
void aritmeticas(Mat in, Mat out, int s, float fact) {
	switch (s)
	{
	case 1:
		for (int i = 0; i < in.rows; i++)
			for (int j = 0; j < in.cols; j++)
			{
				out.at<float>(i, j) = in.at<float>(i, j) + fact;
				if (out.at<float>(i, j) > 255.0)
					out.at<float>(i, j) = 255.0;
				if (out.at<float>(i, j) < 0.0)
					out.at<float>(i, j) = 0.0;
			}
		break;
	case 2:
		for (int i = 0; i < in.rows; i++)
			for (int j = 0; j < in.cols; j++)
			{
				out.at<float>(i, j) = in.at<float>(i, j) - fact;
				if (out.at<float>(i, j) > 255.0)
					out.at<float>(i, j) = 255.0;
				if (out.at<float>(i, j) < 0.0)
					out.at<float>(i, j) = 0.0;
			}
		break;
	case 3:
		for (int i = 0; i < in.rows; i++)
			for (int j = 0; j < in.cols; j++)
			{
				out.at<float>(i, j) = in.at<float>(i, j) * fact;
				if (out.at<float>(i, j) > 255.0)
					out.at<float>(i, j) = 255.0;
				if (out.at<float>(i, j) < 0.0)
					out.at<float>(i, j) = 0.0;
			}
		break;
	case 4:
		for (int i = 0; i < in.rows; i++)
			for (int j = 0; j < in.cols; j++)
			{
				out.at<float>(i, j) = in.at<float>(i, j) / fact;
				if (out.at<float>(i, j) > 255.0)
					out.at<float>(i, j) = 255.0;
				if (out.at<float>(i, j) < 0.0)
					out.at<float>(i, j) = 0.0;
			}
		break;
	default:
		break;
	}
}
void operaciones_img(Mat in1, Mat in2, Mat out) {
	for (int i = 0; i < in1.rows; i++)
		for (int j = 0; j < in1.cols; j++)
		{
			out.at<float>(i, j) = in1.at<float>(i, j) + in2.at<float>(i, j);
			if (out.at<float>(i, j) > 255.0)
				out.at<float>(i, j) = 255.0;
			if (out.at<float>(i, j) < 0.0)
				out.at<float>(i, j) = 0.0;
		}
}
void negativo(Mat in, Mat out) {
	for (int i = 0; i < in.rows; i++)
		for (int j = 0; j < in.cols; j++)
		{
			out.at<float>(i, j) = 255.0 - in.at<float>(i, j);
		}
}
void invertir_v(Mat in, Mat out) {
	for (int i = 0; i < in.rows; i++)
		for (int j = 0; j < in.cols; j++)
		{
			out.at<float>(i, j) = in.at<float>((in.rows - i - 1), (in.cols - j - 1));
		}
}
void invertir_h(Mat in, Mat out) {
	for (int i = 0; i < in.rows; i++)
		for (int j = 0; j < in.cols; j++)
		{
			out.at<float>(i, j) = in.at<float>(i, (in.cols - 1) - j);
		}
}
void f_promedio(Mat in, Mat out) {
	float acu = 0.0;
	for (int i = 1; i < in.rows - 1; i++)
		for (int j = 1; j < in.cols - 1; j++)
		{
			for (int ii = i - 1; ii < i + 2; ii++)
				for (int jj = j - 1; jj < j + 2; jj++)
				{
					acu = in.at<float>(ii, jj) + acu;
				}
			out.at<float>(i, j) = acu / 9.0;
			acu = 0.0;
		}
}
void conteo(Mat in) {
	queue<Vec2i> fifo;
	//int tam[20] = { 0 };
	int cont = 0;
	int tam = 0;
	int t1 = 0;
	int t2 = 0;
	int t3 = 0;
	for (int i = 1; i < in.rows - 1; i++)
		for (int j = 1; j < in.cols - 1; j++) {
			tam = 0;
			if (in.at<float>(i, j) == 255.0) {
				fifo.push(Vec2i(i, j));
				cont = cont + 1;
				in.at<float>(i, j) = cont * 5.0;
				while (!fifo.empty()) {
					Vec2i u = fifo.front();
					fifo.pop();
					for (int ii = u[0] - 1; ii < u[0] + 2; ii++)
						for (int jj = u[1] - 1; jj < u[1] + 2; jj++) {
							if (in.at<float>(ii, jj) == 255.0) {
								
								fifo.push(Vec2i(ii, jj));
								//tam[cont - 1] = fifo.size();
								in.at<float>(ii, jj) = cont * 5.0;
							}
							tam++;
						}
				}
				if (tam < 2000)
					t1++;
				if (tam > 2000 && tam < 4000)
					t2++;
				if (tam > 4000)
					t3++;
				//cout << "Size: " << tam << endl;
			}
		}
	//int a = 0;
	//int b = 0;
	//int c = 0;
	//for (int c = 0; c < cont; c++)
	//{
	//	if (t1 == 0) 
	//		t1 = tam[c];
	//	else if (t2 == 0 && t1 != tam[c])
	//		t2 = tam[c];
	//	else if (t3 == 0 && t1 != tam[c] && t2 != tam[c])
	//		t3 = tam[c];
	//	cout << "Size: " << tam[c] << endl;
	//}
	//for (int c = 0; c < cont; c++)
	//{
	//	if (t1 == 3)
	//		a++;
	//	if (t2 == 2)
	//		b++;
	//	if (t3 == 1)
	//		c++;
	//}
	//cout << "t1: " << t1 << endl;
	//cout << "t2: " << t2 << endl;
	//cout << "t3: " << t3 << endl;
	cout << "Numero de objetos: " << cont << endl;
	cout << "Numeros: " << t1 << endl;
	cout << "Grupo de figura: " << t2 << endl;
	cout << "Figura (Diamantes): " << t3 << endl;
}
void dilatacion(Mat in, Mat aux, int n) {
	for (int a = 0; a <= n; a++) {
		for (int i = 1; i < in.rows - 1; i++)
			for (int j = 1; j < in.cols - 1; j++) {
				if (in.at<float>(i, j) != 0.0) {
					for (int ii = i - 1; ii < i + 2; ii++)
						for (int jj = j - 1; jj < j + 2; jj++)
							aux.at<float>(ii, jj) = 255.0;
				}
			}
	}
}
void erosion(Mat in, Mat out, int n) {
	for (int a = 0; a <= n; a++)
	{
		Mat aux1(in.rows, in.cols, CV_32FC1);
		Mat aux2(in.rows, in.cols, CV_32FC1);
		negativo(in, aux1);
		dilatacion(aux1, aux2, n);
		negativo(aux2, out);
	}
}
void apertura(Mat in, Mat out, int n) {
	Mat aux1(in.rows, in.cols, CV_32FC1);
	erosion(in, aux1, n);
	dilatacion(aux1, out, 1);
}
void cierre(Mat in, Mat out, int n) {
	Mat aux1(in.rows, in.cols, CV_32FC1);
	dilatacion(in, aux1, n);
	erosion(aux1, out, 1);
}
void histograma(Mat in, Mat out) {
	float vec[256] = { 0 };
	float sk[256] = { 0 };
	float vk[256] = { 0 };
	float vkr[256] = { 0 };
	float a = 0.0;
	float skmin, skmax;
	ofstream datos("datos_histograma.txt");
	for (int i = 0; i < in.rows; i++)
		for (int j = 0; j < in.cols; j++)
		{
			a = in.at<float>(i, j);
			vec[int(a)] = vec[int(a)] + 1.0;
		}
	sk[0] = vec[0];
	for (int k = 1; k < 256; k++)
	{
		sk[k] = vec[k] + sk[k - 1];
	}
	skmax = sk[255];
	int ban = 0;
	for (int k = 0; k < 256; k++)
	{
		if (ban == 0)
		{
			if (sk[k] != 0.0)
			{
				skmin = sk[k];
				ban = 1;
			}
		}
	}
	for (int k = 0; k < 256; k++)
	{
		vk[k] = (255.0 * (sk[k] - skmin)) / (skmax - skmin);
		vkr[k] = round(vk[k]);
		datos << vec[k] << "\t" << vkr[k] << endl;
	}
	a = 0.0;
	for (int i = 0; i < in.rows; i++)
		for (int j = 0; j < in.cols; j++)
		{
			a = in.at<float>(i, j);
			out.at<float>(i, j) = vkr[int(a)];

		}
	datos.close();
}
int video(void) {
	int x = 0;
	VideoCapture vid(0);
	if (!vid.isOpened())
		return -1;
	namedWindow("Webcam");
	for (;;) {
		Mat img;
		vid >> img;
		imshow("Video_web", img);
		if (waitKey(50) > 0)
		{
			imwrite("C:/Users/emi_s/Pictures/SVC/pic2.jpg", img);
			break;
		}
	}
	return 0;
}
void bordes(Mat in, Mat out, float x) {
	for (int i = 1; i < in.rows - 1; i++)
		for (int j = 1; j < in.cols - 1; j++)
		{
			if (in.at<float>(i, j) <= x) {
				out.at<float>(i, j) = 255.0 + in.at<float>(i, j);
				if (out.at<float>(i, j) > 255.0)
					out.at<float>(i, j) = 255.0;
				if (out.at<float>(i, j) < 0.0)
					out.at<float>(i, j) = 0.0;
			}
			else
				out.at<float>(i, j) = in.at<float>(i, j);
		}
}