# ���ټ� ��� Bi-LSTM�� �̿��� �ѱ��� ���� �з�
## ����
�� repository���� Python�� �̿��� �ѱ��� ���� �з��� ���� ������ ���� ����(Crawling), ��ó��(Preprocess), ��(model),
�н�����(train)�� �ڼ��� ����� �Բ� ���ԵǾ� �ֽ��ϴ�.
�ؽ�Ʈ �з��� �ڿ��� ó������ ���� �⺻���̰� �߿��� �۾��� �ϳ��ε�, �� repo������ �ѱ��� ���� �з�(n_category : 6)
�� �Ͽ����ϴ�.

  * �ѱ��� ���� ��� ���� (Naver News Crawling.ipynb)
  * ���� ��� ��ó��, Vocabulary����
  * �� (Attention based Bi-LSTM)
  * �н����� (train)

Python Server, Client(C# WPF)�� ����� ��������� �ϸ鼭, Client�� ������ ������ Server���� �н��� �𵨷� ������ ����� �������ִ� �ڵ嵵 �����Ͽ����ϴ�.

  * Server(Python Server)
  * Client(C# WPF)

## �� ����

 ![structure](./image/structure.jpg)

## ���� ���
###Table 1. Accuracy for test dataset
 ![testresult](./image/testresult.PNG)

���¼� ������ ������ ������翡 Attention�� �����Ͽ� ���� ������ ���� ���� �� �� �ֽ��ϴ�.



###Table 2. Accuracy for each field in the trained model
 ![test2](./image/test2.PNG)


###Table 3. Probability for each field when predict is wrong 
 ![test3](./image/test3.PNG)

�� ǥ�� Test���� ������ Ʋ���� ��� ���信 ���� ��� ������ �ߴ��� ������ ��Ÿ�� ǥ�̴�. ��Ȱ/��ȭ �оߴ� ��ȸ �о߷� �߸� ������ ���ɼ��� ���� ������ ���δ�.

## ����

  * prakashpandey9/[Text-Classification-Pytorch][1]
  * jason9693/[NNST-Naver-News-for-Standard-and-Technology-Database][2]

[1]:https://github.com/prakashpandey9/Text-Classification-Pytorch
[2]:https://github.com/jason9693/NNST-Naver-News-for-Standard-and-Technology-Database