참고 자료
- 테스트주도 개발
- C#으로 배우는 적응형 코드
---

## TDD 기본
### 규칙
1. 오직 자동화된 테스트가 실패할 경우에만 새로운 코드를 작성한다
2. 중복을 제거한다

### 프로그래밍 순서
빨랑/초록/리팩토링은 TDD의 주문과도 같은 것이다. 
1. 빨강 - 실패하는 작은 테스트를 작성한다. 처음에는 컴파일조차 되지 않을 수 있다. 
2. 초록 - 빨리 테스트가 통과하게끔 만든다. 이를 위해 어떤 죄악(예: Copy & Paste)을 저질러도 좋다.
3. 리팩토링 - 일단 테스트를 통과하게만 하는 와중에 생겨난 모든 중복을 제거한다. 

### 목적
우리의 목적은 작동하는 깔끔한 코드를 얻는 것이다. 그 과정에서 '작동하는' 에 해당하는 부분을 먼저 해결하고, '깔끔한 코드' 부분을 해결한다. 


## 테스트 케이스 작성 
삼각측량 (동치성)
- A와 B를 알면 C를 검증할 수 있는 것
- 예를 들어서 Equality를 테스트하기 위해서는 True가 되는 Equal을 테스트하고, False가 되는 Equal도 테스트해야 한다

### 단계별 속도
단계
1. 테스트 작성
2. 컴파일되게 하기
3. 실패하는지 확인하기 위해 실행
4. 실행하게 만듬
5. 중복 제거

각 단계에는 서로 다른 목적이 있다. 다른 스타일의 해법, 다른 미적 시작을 필요로 한다. 처음 네 단계는 빨리 진행해야 한다. 그러면 새 기능이 포함되더라도 잘 알고 있는 상태에 이를 수 있다. 거기에 도달하기 위해서라면 어떤 죄든 저지를 수 있다. 그동안 만큼은 속도가 설꼐보다 더 높은 패이기 때문이다. 


### 리팩토링
TDD를 하면서 마지막 단계(중복 제거)에서 코드의 리팩토링이 일어날 수 있다. 

케이스
- 공통된 코드를 상위 클래스로 옮긴다
   - 상위 클래스로 옮기면서 하위 클래스에서 공통적으로 구현되어야 하는 것은 Abstract로 처리
   - 이렇게 하면 상위 클래스에서 Factory Method를 이용하여 하위 클래스 생성에 관여할 수 있다
   - **하위 클래스의 존재를 클라이언트 코드는 알지 못한다. 이를 통해 하위 클래스의 존재를 테스트에서 분리(decoupling)함으로써 어떤 모델 코드에도 영향을 주지 않고 상속 구조를 마음대로 변경할 수 있게 되었다**

## 예시
### 클래스를 명시적으로 참조
클래스를 명시적으로 검사하는 코드가 있을 때에는 항상 다형성을 사용하도록 바꾸는 것이 좋다
```c#
public Money Reduce(IExpression source, string to)
{
   // 변경 전
   //if (source is Money)
   //{
   //    return (Money)source.Reduce(to);
   //}

   //Sum sum = (Sum)source;
   //return sum.Reduce(to);

   // 변경 후
   return source.Reduce(to);
}
```