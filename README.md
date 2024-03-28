# Lunavex.Result NuGet Package

## Overview
The `Lunavex.EFCore.Pagination` package provides a solution for paginating database queries in EF Core applications. It offers a streamlined method to manage large datasets by breaking them into smaller, manageable chunks. This library focuses on simplifying pagination implementation, ensuring efficient data retrieval while maintaining response consistency in .NET applications.

## Features
- **Generic Pagination Result**: Implements a generic pagination result type, allowing for flexible handling of paginated data retrieval operations across diverse data structures.
- **Configurable Page Size**: Supports customizable page sizes, enabling developers to adjust the amount of data fetched per page according to application requirements.
- **Simplified Pagination Logic**: Offers a straightforward pagination logic, abstracting away the complexity of calculating page numbers and total pages, ensuring ease of use.

## Getting Started

### Installation
To integrate `Lunavex.EFCore.Pagination` into your project, install it via the NuGet package manager:

```plaintext
Install-Package Lunavex.EFCore.Pagination
```

Or through the .NET CLI:
```plaintext
dotnet add package Lunavex.EFCore.Pagination
```

## Usage
- **For successful pagination**,  instantiate a PageResult object with the retrieved data:

```csharp
public async Task<PageResult<T>> GetAllAsync(PaginationRequestDto request)
{
    PageResult<T> product= await _context.Products.ToPagedListAsync(request.PageNumber, request.PageSize);
    return product;
}
public sealed record PaginationRequestDto(
    int PageNumber = 1,
    int PageSize = 10,
    );
```

- **Result** :
```csharp
{
  "datas": [
    {
      "id": 1,
      "name": "Product",
      "price": 20
    },
    ...
  ],
  "pageNumber": 1,
  "pageSize": 10,
  "totalPages": 18,
  "isFirstPage": true,
  "isLastPage": false
}
```

## Contributing
We welcome contributions! Feel free to open an issue or submit a pull request on our GitHub repository for any suggestions or improvements.

## License
`Lunavex.EFCore.Pagination` is licensed under the MIT License. See the LICENSE file in the source repository for full details.

```rust
This Markdown formatted README provides a comprehensive guide on how to use the `Lunavex.EFCore.Pagination` package, suitable for your project's repository or documentation.

```