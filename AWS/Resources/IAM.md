IAM
- 통합 계정 관리, Identity & Access Management

AWS IAM
- AWS 리소스에 대한 엑세스를 관리
- 사용자 및 그룹을 만들고 권한을 사용해서 AWS리소스에 대한 액세스 허용 및 거부 가능
- 암호나 액세스 키를 공유하지 않고도 AWS 계정의 리소스를 관리하고 부여할 수 있다

IAM 사용자
- AWS에서 생성하는 개체
- AWS와 서비스 및 리소스와 상호작용 하기 위해 그 개체를 사용하는 사람 또는 서비스

IAM 그룹
- IAM 사용자의 집합

IAM 역할 
- 누구든지 연결 가능하도록 세팅된 역할
- 이렇게 설정된 역할을 서비스나 사용자가 가져와서 사용한다
- 권한의 개념이 있으며, 루트 계정에서 추가해야한다

정책
- AWS 리소스에 접근하기 위해 권한을 허용할지 거부할지를 결정한다
- JSON 형태이며
- 각 그룹, 사용자, 역할에 부여할 수 있다

사용자 정의 구조
- Root 사용자 
- IAM 사용자
- IAM 그룹

IAM 사용자의 접속 링크
- 대시보드에 접속하면 `'IAM 사용자 로그인 링크'` 에서 확인 가능하다
   - `https://{사용자 ID}.signin.aws.amazon.com/console `

예시 1 - Lamda 서비스에 sns 에 데이터를 쓸수 있는 권한을 부여
1. 정책을 생성
   - sns 서비스에 write 할 수 있는 정책을 생성
2. 역할을 생성
   - Lamda 서비스가 앞에서 생성한 정책을 가지도록 설정
   - 역할에는 추가적인 정책을 연결할 수도 있다
3. 람다 함수를 생성할 때 역할 항목에 기 생성한 역할을 선택