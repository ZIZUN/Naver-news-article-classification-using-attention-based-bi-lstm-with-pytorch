# 어텐션 기반 Bi-LSTM을 이용한 한국어 뉴스 분류
## 설명
이 repository에는 Python을 이용한 한국어 뉴스 분류를 위한 데이터 수집 과정(Crawling), 전처리(Preprocess), 모델(model),
학습과정(train)이 자세한 설명과 함께 포함되어 있습니다.
텍스트 분류는 자연어 처리에서 가장 기본적이고 중요한 작업중 하나인데, 이 repo에서는 한국어 뉴스 분류(n_category : 6)
를 하였습니다.

  * 한국어 뉴스 기사 수집 (Naver News Crawling.ipynb)
  * 뉴스 기사 전처리, Vocabulary생성
  * 모델 (Attention based Bi-LSTM)
  * 학습과정 (train)

학습된 모델을 추출하여 Python Server와 Client(C# WPF)가 동기식 소켓통신을 통해 뉴스 분류를 이용할 수 있는 코드도 포함했습니다. 

  * Server(Python Server)
  * Client(C# WPF)

## 실험 결과

형태소 단위로 분절한 뉴스기사에 Attention을 적용하여 높은 성능을 내는 것을 볼 수 있습니다.

 !testresult(./image/testresult.png)

 ![structure](./image/structure.jpg)
