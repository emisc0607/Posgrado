#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>
#include <fstream>
#include <queue>
#include <math.h>
#include <opencv2/objdetect.hpp>
using namespace cv;
using namespace std;
Vec4i p;
int video(void);
void doit(Mat in, Mat out);
void cascada(Mat img);
int main() {
	video();
}

int video(void) {
	VideoCapture vid(1);
	if (!vid.isOpened())
		return -1;
	namedWindow("Video_web");
	Mat img;
	vid >> img;
	for (;;) {
		Mat img;
		Mat rec;
		vid >> img;
		doit(img, rec);
		
		cascada(img);
		
		imshow("Video_web", img);
		if (waitKey(50) > 0)
		{
			//imwrite("C:/Users/emi_s/Pictures/SVC/a31.bmp", img);
			break;
		}
	}
	return 0;
}
void doit(Mat in, Mat out) {
	Mat gris;
	Mat binary;
	Mat inv;
	Mat color;
	Mat rec;
	int area = 0.0;
	float x = 0.0, y = 0.0;
	
	vector<vector<Point>>contornos;
	vector<Vec4i>h;
	Rect a(0, 90, 580, 320);
	rec = in(a);
	cvtColor(rec, gris, COLOR_BGR2GRAY);
	threshold(gris, binary, 110, 255, THRESH_BINARY);
	bitwise_not(binary, inv);
	findContours(inv, contornos, h, RETR_LIST, CHAIN_APPROX_SIMPLE);
	rectangle(in, a, Scalar(0, 255, 255), 2, 1);
	vector<vector<Point>>con_pol(contornos.size());
	for (int i = 0; i < contornos.size(); i++) {
		approxPolyDP(Mat(contornos[i]), con_pol[i], 1, true);
		area = contourArea(contornos[i]);
		Moments m = moments(contornos[i], false);
		x = m.m10 / m.m00;
		y = m.m01 / m.m00;
		Point p(x, y);
		//cout << Mat(p) << endl;
		//cout << "Size: " << con_pol[i].size() << endl;
		if (con_pol[i].size() > 15 and con_pol[i].size() < 30) {
			drawContours(rec, con_pol, i, Scalar(255, 0, 0), 1, 0);
			circle(rec, p, 2, Scalar(255, 255, 0), 2);
			//putText(rec, "Flecha grande", Point(10, 30), FONT_HERSHEY_SIMPLEX, 0.6, Scalar(255, 0, 0), 1, 1);
		}
		else if (con_pol[i].size() > 4 and con_pol[i].size() <=15) {
		drawContours(rec, con_pol, i, Scalar(0, 0, 255), 1, 0);
		circle(rec, p, 2, Scalar(255, 255, 0), 2);
		//cout << "Size: " <<area << endl;
		if(area>500)
		putText(rec, "Flecha grande", Point(10, 45), FONT_HERSHEY_SIMPLEX, 0.6, Scalar(0, 0, 255), 1, 1);
		else
			putText(rec, "Flecha pequena", Point(10, 30), FONT_HERSHEY_SIMPLEX, 0.6, Scalar(255, 0, 0), 1, 1);
		}
	}
//imshow("Invertida", rec);
}
void cascada(Mat img) {
	int a = 0;
	int e1 = 0, e2 = 0, e3 = 0;
	Mat gris(img.rows, img.cols, CV_8UC1);
	CascadeClassifier det;
	vector<Rect> dat;
	det.load("C:/Users/emi_s/Pictures/SVC/engranes2.xml");
	//cout << "ok" << endl;
	cvtColor(img, gris, COLOR_BGR2GRAY);
	det.detectMultiScale(gris, dat);
	cout << "Numero de objetos: " << dat.size() << endl;
	string ne = "Numero de engranes: " + to_string(dat.size());
	putText(img, ne, Point(10, 105), FONT_HERSHEY_COMPLEX, 0.6, Scalar(187, 75, 15), 1, 1);
	for (Rect rect : dat) {
		//cout << "Size: " << rect.size() << endl;
		//cout << "Area: " << rect.area() << endl;

		if (rect.area() <= 9000) {
			e1++;
			string str = to_string(e1);
			putText(img, str, Point(rect.x, rect.y), FONT_HERSHEY_COMPLEX, 0.75, Scalar(255, 0, 0), 1, 1);
			rectangle(img, Point(rect.x, rect.y), Point(rect.x + rect.width, rect.y + rect.height), Scalar(255, 0, 0), 2, 1);
			cout << "Engran pequeno" << endl;
		}
		if (rect.area() > 9000 and rect.area() <= 10500) {
			e2++;
			string str = to_string(e2);
			putText(img, str, Point(rect.x, rect.y), FONT_HERSHEY_COMPLEX, 0.75, Scalar(0, 255, 0), 1, 1);
			rectangle(img, Point(rect.x, rect.y), Point(rect.x + rect.width, rect.y + rect.height), Scalar(0, 255, 0), 2, 1);
			cout << "Engran mediano" << endl;
		}
		if (rect.area() > 10500){
			e3++;
			string str = to_string(e3);
			putText(img, str, Point(rect.x, rect.y), FONT_HERSHEY_COMPLEX, 0.75, Scalar(0, 0, 255), 1, 1);
			rectangle(img, Point(rect.x, rect.y), Point(rect.x + rect.width, rect.y + rect.height), Scalar(0, 0, 255), 2, 1);
			cout << "Engran grande" << endl;
		}
	}
}