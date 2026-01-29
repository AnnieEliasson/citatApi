# <span style="color:grey; text-shadow: 2px 2px 2px black">QuoteAPI - Random Weather Quotes</span>

### 🎲 Random quote

<span style="color:grey; text-shadow: 2px 2px 2px black">- **GET** /api/quote</span>

```
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```
---

### 📚 All quotes

<span style="color:grey; text-shadow: 2px 2px 2px black">- **GET** /api/quote/all</span>

```
[
    {
        "id": 1,
        "text": "Efter regn kommer… mer regn. Men också erfarenhet."
    },
    ...
]
```
---
### 🔎 Quote by Id

<span style="color:grey; text-shadow: 2px 2px 2px black">- **GET** /api/quote/1</span>

```
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```
---

### 🔍 Search quote

<span style="color:grey; text-shadow: 2px 2px 2px black">- **POST** /api/quote/search?s=regn<\span>

```
[
  {
    "id": 1,
    "text": "Efter regn kommer… mer regn. Men också erfarenhet."
  },
  {
    "id": 7,
    "text": "Regn förstör inga planer – det avslöjar bara hur flexibla de var."
  }
]
```
---
