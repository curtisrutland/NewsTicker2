import "../css/site.scss";
import * as React from "react";


export interface TestProps {
  name: string;
}

export const Test: React.SFC<{}> = props => (
  <h1 id="hw">Hello World</h1>
);