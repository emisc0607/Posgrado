#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>
#include <fstream>
#include <queue>
#include <math.h>
using namespace cv;
using namespace std;
Vec4i p;
int video(void);
void doit(Mat in);
int main() {
	video();	
}
int video(void) {
	float u = 75.0;
	VideoCapture vid(1);
	if (!vid.isOpened())
		return -1;
	namedWindow("Video_web");
	Mat img;
	vid >> img;
	for (;;) {
		Mat img;
		vid >> img;
		doit(img);
		if (waitKey(50) > 0)
		{
			//imwrite("C:/Users/emi_s/Pictures/SVC/fc5.jpg", aux1);
			break;
		}
	}
	return 0;
}
void doit(Mat in){
	Mat gris;
	Mat binary;
	Mat inv;
	Mat color;
	Mat rec;
	Mat bin1, bin2;
	Mat inv1, inv2;
	Mat tapa, nivel;
	vector<vector<Point>>contornos;
	vector<Vec4i>h;
	int c = 0.0;
	float x = 0.0, y = 0.0, x1 = 0.0, y1 = 0.0;
	float cx = 0.0, cy = 0.0;
	int area = 0.0;
	float d = 0.0, dx = 0.0, dy = 0.0;
/// Conversion 1 ////
	cvtColor(in, gris, COLOR_BGR2GRAY);
	threshold(gris, binary, 100, 255, THRESH_BINARY);
	bitwise_not(binary, inv);
/// Centroide 1 /////
	Moments m = moments(binary, true);
	x = m.m10 / m.m00;
	y = m.m01 / m.m00;
	Point p(x , y);
	Rect a(x - 90, y - 120, 220, 220);
	//cout << Mat(p) << endl;
/// Recorte ////////
	rec = in(a);
	cvtColor(rec, gris, COLOR_BGR2GRAY);
	threshold(gris, binary, 175, 255, THRESH_BINARY);
	bitwise_not(binary, inv);
	Moments m1= moments(binary, true);
	x1 = m1.m10 / m1.m00;
	y1 = m1.m01 / m1.m00;
	Point p1(x1, y1);
	//cout << Mat(p1) << endl;
	circle(rec, p1, 2, Scalar(128, 0, 128), 2);
/// Contornos //////	
	findContours(inv, contornos, h, RETR_LIST, CHAIN_APPROX_SIMPLE);
	vector<vector<Point>>con_pol(contornos.size());
	cout << "No. objetos: " << contornos.size() << endl;
	for (int i = 0; i < contornos.size(); i++) {
		approxPolyDP(Mat(contornos[i]), con_pol[i], 1, true);
		area = contourArea(contornos[i]);
		Moments mc = moments(contornos[i], false);
		cx = mc.m10 / mc.m00;
		cy = mc.m01 / mc.m00;
		Point pc(cx, cy);
		//cout << "Fig" << i + 1 << ": " << con_pol[i].size() << endl;
		//cout << "FigA" << i + 1 << ": " << area << endl;
		if (con_pol[i].size()>20) {
			drawContours(rec, con_pol, i, Scalar(50, 255, 25), 2, 0);
			circle(rec, pc, 2, Scalar(255, i*5, 0), 2);
			//cout << Mat(pc) << endl;
			//dx = pow(cx - x1, 2);
			//dy = pow(cy - y1, 2);
			dy = cy - y1;
			//d = sqrt(dx+dy);
			//cout << "dx: " << dx << endl;
			cout << "cy, y1 (" << cy << ", " << y1 << ")" << endl;
			cout << "dy: " << dy << endl;
			cout << "Fig" << i + 1 << ": " << con_pol[i].size() << endl;
			//cout << "FigA" << i + 1 << ": " << area << endl;
			if(dy > 0) {
				if (dy > 90 and dy < 97)
					putText(rec, "Llenado C", Point(x1, y1 +12), FONT_HERSHEY_SIMPLEX, 0.5, Scalar(0, 255, 0), 2);
				else 
					putText(rec, "Llenado I", Point(x1, y1 +12), FONT_HERSHEY_SIMPLEX, 0.5, Scalar(0, 0, 255), 2);
			}
			if (dy < 0) {
				d = dy * -1;
				if (d > 40 and d < 57)
					putText(rec, "Tapa C", /*Point(x1 + 15, y1 - 92)*/ p1, FONT_HERSHEY_SIMPLEX, 0.5, Scalar(0, 255, 0), 2);
				else if (contornos[i].size() > 40)
					putText(rec, "Tapa I", /*Point(x1 + 15, y1 - 92)*/ p1, FONT_HERSHEY_SIMPLEX, 0.5, Scalar(0, 0, 255), 2);
			}
		}
	}
	imshow("Video_web", rec);

	//imshow("invertida2", inv);
	//imshow("Centroide2", in);
	//imshow("gris2", gris);
	//imshow("binaria2", binary);
	//if (waitKey(50) > 0)
	//{
	//	imwrite("C:/Users/emi_s/Pictures/SVC/rec.jpg", rec);
	//	imwrite("C:/Users/emi_s/Pictures/SVC/inv.jpg", inv);
	//}
}