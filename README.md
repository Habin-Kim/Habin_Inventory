# Habin_Inventory
인벤토리 구현하기 과제 제출용 입니다.

## 🌟 주요 기능

- **🧾 아이템 데이터 관리**  
  - `ScriptableObject` 기반 `ItemData`로 아이템 이름, 아이콘, 설명, 능력치 보너스를 정의  

- **🎒 인벤토리 시스템**  
  - `GameManager`에서 `Character`의 인벤토리에 `ItemData`를 추가  
  - 최대 슬롯 수를 지정해 UI에 동적으로 슬롯 생성  

- **🛡️ 장비 착·탈**  
  - `UISlot` 클릭 시 `Character.Equip()` / `UnEquip()` 호출  
  - 착용 상태에 따라 스탯(ATK/DEF/HP/CRI) 자동 업데이트  

- **🖥️ UI 구성**  
  - `UIMainMenu`: 캐릭터 이름·레벨 표시, 상태창 및 인벤토리 오픈 버튼  
  - `UIStatus`: 캐릭터 스탯(HP/ATK/DEF/CRI) 표시  
  - `UIInventory`: 슬롯 그리드 생성·업데이트, 아이템 개수 표시  


## 📜 스크립트 요약

### 🧍 Character.cs  
- 캐릭터 정보(이름, 레벨, 스탯)를 포함  
- 인벤토리를 `List<ItemData>`로 보유  
- `Equip` / `UnEquip` 메서드를 통해 장비 착용 시 스탯 보너스 적용 및 해제  

### 💎 ItemData.cs  
- `ScriptableObject`로 생성 가능한 아이템 데이터  
- 이름, 아이콘, 설명, ATK/DEF/HP/CRI 보너스 포함  

### 🎁 Item.cs  
- 씬 상의 GameObject에 부착해 아이템 프리팹으로 활용  
- `ItemData` 참조 및 간단한 헬퍼 메서드 제공  

### 🧠 GameManager.cs  
- 싱글톤 패턴으로 캐릭터 및 초기 아이템 로드 담당  
- `itemObjects` 리스트를 순회하며 인벤토리에 아이템 추가  

### 🖼️ UI 스크립트

#### UIManager.cs  
- 메인 화면, 상태창, 인벤토리 등 UI 전환 관리  

#### UIMainMenu.cs  
- 캐릭터 이름과 레벨 표시  
- 버튼 이벤트로 상태창 및 인벤토리 오픈  

#### UIStatus.cs  
- 캐릭터의 현재 스탯(HP, ATK, DEF, CRI) 표시  

#### UIInventory.cs  
- 슬롯 생성 및 그리드 레이아웃 구성  
- 아이템 개수 실시간 업데이트  

#### UISlot.cs  
- 슬롯 클릭 시 장비 착용/해제 처리  
- 아이콘 표시 및 장비 상태 시각화


## 🛠️ 커스터마이징

### 🔢 슬롯 수 변경  
- `UIInventory` 스크립트의 `maxSlotCount` 값을 수정하여 인벤토리 슬롯 수 조절 가능  

### ➕ 아이템 능력치 추가  
1. `ItemData`에 새로운 능력치 필드 추가 (예: SPD, LUK 등)  
2. `Character` 스크립트의 `Equip` / `UnEquip` 메서드에서 해당 능력치 반영  

### 💰 골드 시스템 추가  
1. `Character`에 `Gold` 프로퍼티 및 초기 값 추가  
2. `UIMainMenu`에서 골드 표시 UI 추가  
3. 아이템 구매/판매 기능과 연동 가능 (추후 확장 시)  
