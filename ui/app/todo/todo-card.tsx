import { Card } from "react-bootstrap";
import type { Todo } from "./todo";

type TodoCardProps = {
    todo: Todo
};

export function TodoCard({todo}: TodoCardProps) {
    return (
        <Card style={{ width: '18rem' }}>
            <Card.Title>{todo.title}</Card.Title>
            <Card.Text>{todo.description}</Card.Text>
        </Card>
    );


}