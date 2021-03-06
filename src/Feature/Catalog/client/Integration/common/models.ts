//    Copyright 2020 EPAM Systems, Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

import { ProductModel } from 'Foundation/Commerce/client';
import * as Jss from 'Foundation/ReactJss/client';

export enum StockStatus {
  InStock = 'InStock',
  OutOfStock = 'OutOfStock',
  PreOrderable = 'PreOrderable',
  BackOrderable = 'BackOrderable',
}

export interface Category {
  sitecoreId: string;
  name: string;
  displayName: string;
  description: string;
  parentCatalogList: string[];
  childrenCategoryList: string[];
}

export interface CategoryContext {
  category: Category;
}

export interface ProductContext {
  product: ProductModel;
}

export interface SitecoreContext extends CategoryContext, ProductContext {}

export interface AppState extends Jss.SitecoreState<SitecoreContext> {}
